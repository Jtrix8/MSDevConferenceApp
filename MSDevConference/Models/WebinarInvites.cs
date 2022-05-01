using System;
using System.ComponentModel.DataAnnotations;

namespace MSDevConference.Models
{
	public class WebinarInvites
	{
		
		[Required(ErrorMessage = "Please enter your name.")]
		public string Name { get; set; }

		[Required(ErrorMessage = "Please enter your email.")]
		public string Email { get; set; }

		[Required(ErrorMessage = "Please enter your phone number.")]
		public string Phone { get; set; }

		[Required(ErrorMessage = "Please state whether you will attend.")]
		public bool? WillJoin { get; set; }
	}
}

