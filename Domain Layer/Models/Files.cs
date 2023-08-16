using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain_Layer.Models
{
    public class Files : MedicalFromModel
    {
        public byte[] MedicalAttachments { get; set; }

        public byte[] ReverteeCertificate { get; set; }

        public byte[] TravellingAttachment { get; set; }

        public byte[] OverSeaHospitalDocument { get; set; }

        public string Signature { get; set; }

        
    }
}

