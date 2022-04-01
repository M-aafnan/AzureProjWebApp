using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using Azure.Storage.Blobs;

namespace PracADOWeb.Models.Helpers
{
    public class BlobManagementHelper
    {
        public void AddFileToBlob(HttpPostedFileBase file)
        {

            string targetFolder = HttpContext.Current.Server.MapPath("~/Content/FileUploads");
            string targetPath = Path.Combine(targetFolder, file.FileName);
            file.SaveAs(targetPath);

            var connectionString = "DefaultEndpointsProtocol=https;AccountName=bulkorderjsonfiles;AccountKey=yNJI+kS655vC5RwB5yO/i/kqeXMSBeObjNqsMAr6CogkmwDLZtRsVgdmAFBfgc1CGAyLLIT5cQY++AStSaB8PA==;EndpointSuffix=core.windows.net";

            // intialize BobClient 
            BlobClient blobClientForUploadFile = new BlobClient(
                connectionString: connectionString,
                blobContainerName: "orderfiles",
                blobName: "myblog" + DateTime.UtcNow.Ticks.ToString());

            // upload the file
            blobClientForUploadFile.Upload(targetPath);

            File.Delete(targetPath);
            

        }

        

    }
}