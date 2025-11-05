using System;
using System.IO;
using System.Threading.Tasks;
using Azure.Storage.Blobs;
using Azure.Storage.Blobs.Models;
using Microsoft.AspNetCore.Http;

namespace SISPAE.Business.Services
{

    public interface IBlobStorageService
    {
        //Ref:
        //https://offering.solutions/blog/articles/2020/08/09/uploading-files-to-azure-blob-storage-with-angular-and-asp.net-core/

        Task<string> UploadFileToBlobAsync(IFormFile file, string cnx, string fln, string uc);
        //Task<string> UploadFileToBlobAsync(string fileName, Stream filestream, string contentType);
        Task<BlobDownloadInfo> GetBlobAsync(string filename, string uc, string cnx);
    }


    public class BlobStorageService : IBlobStorageService
    {
        public async Task<string> UploadFileToBlobAsync(IFormFile file, string cnx, string fln, string uc)
        {
            try
            {
                //var container = new BlobContainerClient("DefaultEndpointsProtocol=https;AccountName=sispaestorage;AccountKey=fbRNpOcLBd51RlF/wh5P+Ct65x7Sz7DOly7ns4i9ewwBfNfTZehCV9tn/86tAqoRZmmTG5mt1QEWRbNRkkBaSA==;EndpointSuffix=core.windows.net", "upload-container");
                var container = new BlobContainerClient(cnx, uc);


                var filename = string.IsNullOrEmpty(fln) ? GenerateFileName(file.FileName) : fln;

                // Method to create our container if it doesn’t exist.
                var createResponse = await container.CreateIfNotExistsAsync();

                // If container successfully created, then set public access type to Blob.
                if (createResponse != null && createResponse.GetRawResponse().Status == 201)
                    await container.SetAccessPolicyAsync(Azure.Storage.Blobs.Models.PublicAccessType.Blob);

                // Method to create a new Blob client.
                var blob = container.GetBlobClient(filename);

                // If a blob with the same name exists, then we delete the Blob and its snapshots.
                await blob.DeleteIfExistsAsync(Azure.Storage.Blobs.Models.DeleteSnapshotsOption.IncludeSnapshots);

                // Create a file stream and use the UploadSync method to upload the Blob.
                using (var fileStream = file.OpenReadStream())
                {
                    var result = await blob.UploadAsync(fileStream, new BlobHttpHeaders { ContentType = file.ContentType });
                }

                return filename;
            }
            catch (Exception ex)
            {
                throw (ex);
            }
        }

        //public async Task<string> UploadFileToBlobAsync(string fileName, Stream filestream, string contentType)
        //{
        //    try
        //    {
        //        var container = new BlobContainerClient("DefaultEndpointsProtocol=https;AccountName=sispaestorage;AccountKey=fbRNpOcLBd51RlF/wh5P+Ct65x7Sz7DOly7ns4i9ewwBfNfTZehCV9tn/86tAqoRZmmTG5mt1QEWRbNRkkBaSA==;EndpointSuffix=core.windows.net", "upload-container");

        //        var filename = GenerateFileName(fileName);

        //        // Method to create our container if it doesn’t exist.
        //        var createResponse = await container.CreateIfNotExistsAsync();

        //        // If container successfully created, then set public access type to Blob.
        //        if (createResponse != null && createResponse.GetRawResponse().Status == 201)
        //            await container.SetAccessPolicyAsync(Azure.Storage.Blobs.Models.PublicAccessType.Blob);

        //        // Method to create a new Blob client.
        //        var blob = container.GetBlobClient(fileName);

        //        // If a blob with the same name exists, then we delete the Blob and its snapshots.
        //        await blob.DeleteIfExistsAsync(Azure.Storage.Blobs.Models.DeleteSnapshotsOption.IncludeSnapshots);

        //        // Create a file stream and use the UploadSync method to upload the Blob.
        //        using (filestream)
        //        {
        //            var result = await blob.UploadAsync(filestream, new BlobHttpHeaders { ContentType = contentType });
        //        }

        //        return filename;
        //    }
        //    catch (Exception ex)
        //    {
        //        throw (ex);
        //    }
        //}


        public async Task<BlobDownloadInfo> GetBlobAsync(string filename, string uc, string cnx)
        {
            var blobClient = new BlobClient(cnx, uc, filename);

            //var blobClient = new BlobClient(
            //    "DefaultEndpointsProtocol=https;AccountName=sispaestorage;AccountKey=fbRNpOcLBd51RlF/wh5P+Ct65x7Sz7DOly7ns4i9ewwBfNfTZehCV9tn/86tAqoRZmmTG5mt1QEWRbNRkkBaSA==;EndpointSuffix=core.windows.net",
            //    "upload-container", filename);

            var result = await blobClient.DownloadAsync();
            return result;
        }

        private string GenerateFileName(string fileName)
        {
            string strFileName = string.Empty;
            string[] strName = fileName.Split('.');
            strFileName = DateTime.Now.ToUniversalTime().ToString("yyyyMMdd\\THHmmssfff") + "." + strName[strName.Length - 1];
            return strFileName;
        }
    }

    public class BlobDto
    {
        public byte[] Content { get; set; }

        public string Name { get; set; }
    }
}
