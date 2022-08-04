using Feasablty_study.Domin.Interfaces;
using System;

namespace Feasablty_study.Models
{
    public class Construction_and_buliding : IEntityBase
    {
        public int Id { get; set; }

        public string BuildingType { get; set; }

        public string Title { get; set; }

        public string SendPrivateSender { get; set; }

        public DateTime DateTime { get; set; }
        public int TechnicalStudyId { get; set; }
        public Technical_Study technical_Study { get; set; }
    }
}
