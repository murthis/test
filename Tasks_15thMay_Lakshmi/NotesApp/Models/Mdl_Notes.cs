using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace NotesApp.Models
{
    [MetadataType(typeof(NotesMetaData))]
    public partial class tbl_Notes
    {

    }

    public class NotesMetaData
    {
        [Required]
        public string Name { get; set; }

    }
}