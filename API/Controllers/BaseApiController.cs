using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace API.Controllers;

/// <summary>
/// Base controller for API endpoints.
/// This controller can be extended by other controllers to inherit common functionality.
/// It is marked with the [ApiController] attribute to enable API-specific behaviors.
/// </summary>
/// <remarks>
/// The [ApiController] attribute enables automatic model validation, binding source inference,
/// and other API-specific features.
/// Controllers inheriting from this base controller can focus on their specific logic
/// without worrying about common setup.
/// </remarks>
[ApiController]
public class BaseApiController : ControllerBase
{

}