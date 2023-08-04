using Domain_Layer.Data;
using Domain_Layer.Models;
using Microsoft.AspNetCore.Mvc;
using System.Security.Cryptography.Xml;

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

        [HttpGet]
        public IActionResult Add()

        {
            var viewModel = new medicalFromViewModel();
            return View(viewModel);
        }

        [HttpPost]
        public async Task<IActionResult> Add(medicalFromViewModel model, List<IFormFile> files) 
        {





            foreach (var file in files)
            {
                using (var target = new MemoryStream())
                {
                    file.CopyTo(target);

                    if (file.Name == "MedicalAttachments")
                    {
                        model.MedicalAttachments = target.ToArray();
                        model.MedicalAttachmentFileName = model.MedicalAttachmentDetails;
                        model.MedicalAttachmentFileName = file.FileName;
                    }
                    else if (file.Name == "TravellingAttachment")
                    {
                        model.TravellingAttachment = target.ToArray();
                        model.TravellingAttachmentFileName = model.TransportDocument;
                        model.TravellingAttachmentFileName = file.FileName;
                    }
                    else if (file.Name == "OverSeaHospitalDocument")
                    {
                        model.OverSeaHospitalDocument = target.ToArray();
                        model.OverSeasHospitalName = model.OverSeasHospitalName;
                        model.OverSeasHospitalName = file.FileName;
                    }
                    else if (file.Name == "ReverteeCertificate")
                    {
                        model.ReverteeCertificate = target.ToArray();
                        model.ReverteeCertificateFileName = model.IsRevertee.ToString();
                        model.ReverteeCertificateFileName = file.FileName;
                    }
                }

                model.Signature = Convert.ToBase64String(ConvertDataUrlToByteArray(model.Signature));


                var newForm = new MedicalFromModel()
                {
                    FirstName = model.FirstName,
                    SecondName = model.LastName,
                    LastName = model.LastName,
                    IDNo = model.IDNo,
                    Email = model.Email,
                    TelPhone = model.TelPhone,
                    PoBoxNo = model.PoBoxNo,
                    Town = model.Town,
                    PatientRepName = model.PatientRepName,
                    PatientRepPhone = model.PatientRepPhone,
                    Relation = model.Relation,
                    NatureOfillness = model.NatureOfillness,                    HospitalName = model.HospitalName,
                    County = model.County,
                    MedicalAttachmentDetails = model.MedicalAttachmentDetails,
                    FamilyContribution = model.FamilyContribution,
                    NHIFcontribution = model.NHIFcontribution,
                    HospitalBillBalance = model.HospitalBillBalance,
                    IsRevertee = model.IsRevertee,
                    AdditionalInfo = model.AdditionalInfo,
                    TransportDocument = model.TransportDocument,
                    OverSeasHospitalName = model.OverSeasHospitalName,
                    OverSeaCountry = model.OverSeaCountry,
                    Date = model.Date,
                    createdDate = DateTime.Now,
                    modfiedDate = DateTime.Now,
                    MedicalAttachments = model.MedicalAttachments,
                    ReverteeCertificate = model.ReverteeCertificate,
                    TravellingAttachment= model.TravellingAttachment,
                    OverSeaHospitalDocument= model.OverSeaHospitalDocument,
                    MedicalAttachmentFileName = model.MedicalAttachmentFileName,
                    TravellingAttachmentFileName = model.TravellingAttachmentFileName,
                    HospitalAttachmentFileName = model.MedicalAttachmentFileName,
                    ReverteeCertificateFileName = model.ReverteeCertificateFileName,
                    Signature = model.Signature,

                };


                //using (var target2 = new MemoryStream())
                //{
                //    file.CopyTo(target2);
                //    newForm.TravellingAttachment = target2.ToArray();
                //}

                //using (var target3 = new MemoryStream())
                //{
                //    files.CopyTo(target3);
                //    newForm.OverSeaHospitalDocument = target3.ToArray();
                //}


                //using (var target4 = new MemoryStream())
                //{
                //    files.CopyTo(target4);
                //    newForm.ReverteeCertificate = target4.ToArray();
                //}

                await medicalFormDbContext.MedicalFrom.AddAsync(newForm);
                await medicalFormDbContext.SaveChangesAsync();
               
            }

            return View(model);

           
        }
        private byte[] ConvertDataUrlToByteArray(string dataUrl)
        {
            var base64Data = dataUrl.Split(',')[1];
            return Convert.FromBase64String(base64Data);
        }



    };
}
