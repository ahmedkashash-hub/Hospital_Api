using Hospital.Domain.Common;
using System;
using System.Collections.Generic;
using System.Text;

namespace Hospital.Domain.Enyities
{
    public class Report:BaseEntity
    {
        public string ReportName { get;private set; }= string.Empty;
        public string ReportType { get;private set; }= string.Empty;
        public string CreateBy { get; private set; } = string.Empty;
        public string FilePath { get; private set; } = string.Empty;
        public string ReportDescreption { get; private set; } = string.Empty;
        public string Note { get;private set; }= string.Empty;
        public DateTime CreatedDate { get; private set; }
        public DateTime LastModifiedDate { get; private set; }
        public bool IsSchedulled { get; private set; }

        public Report Create(string reportName, string reportType, string createBy, string filePath, string reportDescreption, string note, bool isSchedulled)
        {
            return new Report {
                ReportName = reportName,
                ReportType = reportType,
                CreateBy = createBy,
                FilePath = filePath,
                ReportDescreption = reportDescreption,
                Note = note,
                CreatedDate = DateTime.Now,
                LastModifiedDate = DateTime.Now,
                IsSchedulled = isSchedulled
            }; }
        public void Update(string reportName, string reportType, string createBy, string filePath, string reportDescreption, string note, bool isSchedulled)
        {
            ReportName = reportName;
            ReportType = reportType;
            CreateBy = createBy;
            FilePath = filePath;
            ReportDescreption = reportDescreption;
            Note = note;
            LastModifiedDate = DateTime.Now;
            IsSchedulled = isSchedulled;
        }
        }
}
