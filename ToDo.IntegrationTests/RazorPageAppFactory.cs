﻿using Microsoft.AspNetCore.Mvc.Testing;
using System;
using System.Collections.Generic;
using System.Text;

namespace ToDo.IntegrationTests
{
    public class RazorPageAppFactory : WebApplicationFactory<ToDo.RazorPages.Startup>
    {
    }
}
