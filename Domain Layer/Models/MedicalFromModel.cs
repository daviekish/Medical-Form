using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain_Layer.Models
{
    public class MedicalFromModel : baseEntity
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

        public string PatientRepPhone { get; set;}

        public string Relation { get; set; }

        public string NatureOfillness { get; set; } 

        public string HospitalName { get; set; } 

        public string County { get; set; }

        [Required]
        public string MedicalAttachmentDetails { get; set; }

        // medical attachments
        [Required]
       

        public string MedicalAttachmentFileName { get; set; }

        public double FamilyContribution { get; set; }

        public double NHIFcontribution { get; set; }

        public double HospitalBillBalance { get; set; }

        [Required]
        public bool IsRevertee { get; set; }

        // Revertee certificate attachments
        [Required]
       

        public string ReverteeCertificateFileName { get; set; }

        public string AdditionalInfo { get; set; }

        [Required]
        public string TransportDocument { get; set; }

        //Traveeling  attachements
        [Required]
      

        public string TravellingAttachmentFileName { get; set; }

        public string OverSeasHospitalName { get;set; }

        public string OverSeaCountry { get; set; }


        //Oversea doc attachements
       

        public string HospitalAttachmentFileName { get; set; }

        public DateTime Date { get; set; }



       
    }
}
