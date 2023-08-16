using Domain_Layer.Data;
using Domain_Layer.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Http;
using System.Security.Cryptography.Xml;
using System;

namespace MedicalAssistanceFrom.Controllers
{
    public class MedicalFormController : Controller
    {
        private readonly MedicalFormDbContext medicalFormDbContext;
        private readonly MedicalFromModel medicalForm;

        public MedicalFormController(MedicalFormDbContext medicalFormDbContext, MedicalFromModel medicalForm)
        {
            this.medicalFormDbContext = medicalFormDbContext;
            this.medicalForm = medicalForm;
        }


        public IActionResult Add()

        {
            var viewModel = new medicalFromViewModel();
            return View(viewModel);
        }


        [HttpPost]
        public async Task<IActionResult> Add(medicalFromViewModel model, List<IFormFile> files, Files attachment)
        {

            foreach (var file in files)
            {
                var fileName = Path.GetFileNameWithoutExtension(file.FileName);
                var fileModel = new Files
                {
                    createdDate = DateTime.Now,
                    Signature = model.Signature
                                        
                };

                using (var dataStream = new MemoryStream())
                {
                    await dataStream.CopyToAsync(dataStream);
                    fileModel.MedicalAttachments = dataStream.ToArray();
                    model.MedicalAttachmentFileName = fileName;
                }

                using (var dataStream = new MemoryStream())
                {
                    await dataStream.CopyToAsync(dataStream);
                    fileModel.ReverteeCertificate= dataStream.ToArray();
                    model.ReverteeCertificateFileName = fileName;
                }

                using (var memoryStream = new MemoryStream())
                {
                    await memoryStream.CopyToAsync(memoryStream);
                    fileModel.TravellingAttachment = memoryStream.ToArray();
                    model.ReverteeCertificateFileName = fileName;
                }

                using (var memoryStream = new MemoryStream())
                {
                    await memoryStream.CopyToAsync(memoryStream);
                    fileModel.OverSeaHospitalDocument = memoryStream.ToArray();
                    model.HospitalAttachmentFileName = fileName;
                }
               
                await medicalFormDbContext.MedicalFrom.AddAsync(fileModel);
            }

            attachment.Signature = Convert.ToBase64String(ConvertDataUrlToByteArray(attachment.Signature));

            var newForm = new MedicalFromModel()
                {
                    FirstName = model.FirstName,
                    SecondName = model.SecondName,
                    LastName = model.LastName,
                    IDNo = model.IDNo,
                    Email = model.Email,
                    TelPhone = model.TelPhone,
                    PoBoxNo = model.PoBoxNo,
                    Town = model.Town,
                    PatientRepName = model.PatientRepName,
                    PatientRepPhone = model.PatientRepPhone,
                    Relation = model.Relation,
                    NatureOfillness = model.NatureOfillness,
                    HospitalName = model.HospitalName,
                    County = model.County,
                    MedicalAttachmentDetails = model.MedicalAttachmentDetails,
                    MedicalAttachmentFileName = model.MedicalAttachmentFileName,
                    FamilyContribution = model.FamilyContribution,
                    NHIFcontribution = model.NHIFcontribution,
                    HospitalBillBalance = model.HospitalBillBalance,
                    IsRevertee = model.IsRevertee,
                    ReverteeCertificateFileName = model.ReverteeCertificateFileName,
                    AdditionalInfo = model.AdditionalInfo,
                    TransportDocument = model.AdditionalInfo,
                    TravellingAttachmentFileName = model.TravellingAttachmentFileName,
                    OverSeasHospitalName = model.OverSeasHospitalName,
                    OverSeaCountry = model.OverSeaCountry,
                    HospitalAttachmentFileName = model.HospitalAttachmentFileName,
                    Date = DateTime.Now,
                    createdDate = DateTime.Now,
                    modfiedDate = DateTime.Now,
                };
     
                await medicalFormDbContext.MedicalFrom.AddAsync(newForm);
                await medicalFormDbContext.SaveChangesAsync();


            

            return View(model);

        }

        //private void SaveAttachment (IFormFile file, ref byte[] target)
        //{   
        //        using (var memoryStream = new MemoryStream())
        //        {
        //            file.CopyTo(memoryStream);
        //             target = memoryStream.ToArray();
        //        }
            
        //}


        private byte[] ConvertDataUrlToByteArray(string dataUrl)
        {
            if (string.IsNullOrEmpty(dataUrl))
            {
                throw new ArgumentException(nameof(dataUrl), "dataUrl cannot be null or empty");

            }

            var dataParts = dataUrl.Split(',');

            if (dataParts.Length < 2 )
            {
                throw new ArgumentException("Invalid dataUrl format.", nameof(dataUrl));
            }
             var base64Data = dataUrl.Split(',')[1];

            return Convert.FromBase64String(base64Data);
        }

       

    }
};

