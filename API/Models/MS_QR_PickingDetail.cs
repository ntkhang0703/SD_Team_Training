﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace API.Models
{
    public partial class MS_QR_PickingDetail
    {
        [Key]
        [StringLength(1)]
        public string manuf { get; set; }
        [Column(TypeName = "date")]
        public DateTime Sdat { get; set; }
        [Column(TypeName = "date")]
        public DateTime? iodat { get; set; }
        [Key]
        [StringLength(12)]
        public string pickingTrNo { get; set; }
        [Required]
        [StringLength(12)]
        public string storageTrNo { get; set; }
        [Required]
        [StringLength(1)]
        public string Grade { get; set; }
        [Key]
        [StringLength(13)]
        public string QRCodeID { get; set; }
        [Required]
        [StringLength(15)]
        public string manno { get; set; }
        [Required]
        [StringLength(10)]
        public string purno { get; set; }
        [Column(TypeName = "decimal(5, 0)")]
        public decimal serial { get; set; }
        [Required]
        [StringLength(4)]
        public string size { get; set; }
        [Column(TypeName = "decimal(7, 1)")]
        public decimal qty { get; set; }
        [StringLength(6)]
        public string crusr { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? crday { get; set; }
        /// <summary>
        /// &#27966;&#24037;&#21934;&#34399;
        /// </summary>
        [Required]
        [StringLength(10)]
        public string wkshno { get; set; }
        /// <summary>
        /// &#21015;&#21360;&#21934;&#34399;
        /// </summary>
        [Required]
        [StringLength(10)]
        public string prtno { get; set; }
        [Column(TypeName = "decimal(7, 1)")]
        public decimal wkshqty { get; set; }
        [Column(TypeName = "date")]
        public DateTime mdat { get; set; }
        [Required]
        [StringLength(5)]
        public string empno { get; set; }
        /// <summary>
        /// &#21697;&#34399;
        /// </summary>
        [Required]
        [StringLength(16)]
        public string bitnbr { get; set; }
        /// <summary>
        /// &#38795;&#24288;&#26009;&#34399;
        /// </summary>
        [Required]
        [StringLength(10)]
        public string ritnbr { get; set; }
    }
}
