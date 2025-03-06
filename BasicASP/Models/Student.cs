﻿using System.ComponentModel.DataAnnotations;

namespace BasicASP.Models
{
	public class Student
	{
		[Key]
		public int Id { get; set; }

		[Required]
		public string? Name { get; set; }


		public int Score { get; set; }
	}
}
