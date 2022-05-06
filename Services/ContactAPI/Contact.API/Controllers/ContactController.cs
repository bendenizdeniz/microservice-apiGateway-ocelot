﻿using Contact.API.Infrastructure;
using Contact.API.Models;
using Microsoft.AspNetCore.Mvc;

namespace Contact.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ContactController : ControllerBase
    {
        private readonly IContactService contactService;

        public ContactController(IContactService contactService)
        {
            this.contactService = contactService;
        }

        [HttpGet("{Id}")]
        public ContactDTO GetContactById(int Id)

        {
            return contactService.GetContactById(Id);
        }
    }
}
