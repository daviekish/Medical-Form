using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain_Layer.Models
{
    public class medicalFromViewModel
    {
        [Required]
        public string FirstName { get; set; }

        public string SecondName { get; set; }

        [Required]
        public string LastName { get; set; }

        [Required]
        public int IDNo { get; set; }

        [Required]
        public string Email { get; set; }

        [Required]  
        public string TelPhone { get; set; }

        public string PoBoxNo { get; set; }

        public string Town { get; set; }

        public string PatientRepName { get; set; }

        public string PatientRepPhone { get; set; }

        public string Relation { get; set; }

        public string NatureOfillness { get; set; }

        public string HospitalName { get; set; }

        public string County { get; set; }

        [Required]
        public string MedicalAttachmentDetails { get; set; }

        // medical attachments
        [Required]
        public byte[] MedicalAttachments { get; set; }

        public string MedicalAttachmentFileName { get; set; }

        public double FamilyContribution { get; set; }

        public double NHIFcontribution { get; set; }

        public double HospitalBillBalance { get; set; }

        [Required]
        public bool IsRevertee { get; set; }

        // Revertee certificate attachments
        [Required]
        public byte[] ReverteeCertificate { get; set; }
        public string ReverteeCertificateFileName { get; set; }

        public string AdditionalInfo { get; set; }

        [Required]
        public string TransportDocument { get; set; }

        //Traveeling  attachements
        [Required]
        public byte[] TravellingAttachment { get; set; }
        public string TravellingAttachmentFileName { get; set; }

        public string OverSeasHospitalName { get; set; }

        public string OverSeaCountry { get; set; }

        //Oversea doc attachements
        [Required]
        public byte[] OverSeaHospitalDocument { get; set; }
        public string HospitalAttachmentFileName { get; set; }

        public DateTime Date { get; set; }

        [Required]
        public string Signature { get; set; }
    }
}
