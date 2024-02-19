﻿using System;
using Entities.Concrete;
using Business.Abstract;

namespace Business.Concrete
{
	public class PttManager:ISupplierService
	{
		private IApplicantService _applicantService;

		public PttManager(IApplicantService applicantService) //Constructor blok
		{
			_applicantService = applicantService;
		}
		public void GiveMask(Person person)
		{

			if (_applicantService.CheckPerson(person))
			{
				Console.WriteLine(person.FirstName + " için maske verildi.");

			}
		}
	}
}

