﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Runtime.InteropServices.Marshalling;
using System.Text;
using System.Threading.Tasks;

namespace PM.Domain
{
    [Table(name: "Project")]
    public class Project
    {
        [Key]
        public string Id { get; set; } = string.Empty;
        [Column(name: "Project Name")]
        public string ProjectName { get; set; } = string.Empty;
        [Column(name: "Project Description")]
        public string ProjectDescription { get; set; } = string.Empty;
        [Column(name: "Project Status")]
        [ForeignKey(nameof(Status))]
        public int StatusId {  get; set; }
        public Status Status { get; set; }
        [Column(name: "Create At")]
        public DateTime CreateAt { get; set; }
        [Column(name: "Start At")]
        public DateTime StartAt { get; set; }
        [Column(name: "End At")]
        public DateTime EndAt { get; set; }
        [Column(name: "Is Deleted")]
        public bool IsDeleted { get; set; }
        [Column(name: "Is Accessed")]
        public bool IsAccessed { get; set; }
        [Column(name: " Is Done")]
        public bool IsDone { get; set; }
    }
}
