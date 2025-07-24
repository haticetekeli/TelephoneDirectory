using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TelephoneDirectory.Core.ResponseManager;
using Microsoft.AspNetCore.Mvc;
using System.Net;
using Microsoft.AspNetCore.Authorization;
using System.Runtime.InteropServices;
using TelephoneDirectory.Core;


[ApiController]
[Authorize]
[Route("api/[controller]")]
public abstract class BaseController : TelephoneDirectory.Core.ControllerBase
{


    protected IActionResult HandleResponse(BaseResponseModel responseModel)
    {
        if (responseModel.StatusCode == (int)HttpStatusCode.OK)
        {
            return Ok(responseModel);
        }
        else if (responseModel.StatusCode == (int)HttpStatusCode.BadRequest)
        {
            return BadRequest(responseModel);
        }
        else
        {
            return StatusCode((int)HttpStatusCode.InternalServerError, responseModel);
        }
    }

    private IActionResult StatusCode(int ınternalServerError, BaseResponseModel responseModel)
    {
        throw new NotImplementedException();
    }

    private IActionResult BadRequest(BaseResponseModel responseModel)
    {
        throw new NotImplementedException();
    }

    private IActionResult Ok(BaseResponseModel responseModel)
    {
        throw new NotImplementedException();
    }

    protected IActionResult HandleResponse<T>(BaseResponseModel<T> responseModel)
    {
        if (responseModel.StatusCode == (int)HttpStatusCode.OK)
        {
            return Ok(responseModel);
        }
        else if (responseModel.StatusCode == (int)HttpStatusCode.BadRequest)
        {
            return BadRequest(responseModel);
        }
        else
        {
            return StatusCode((int)HttpStatusCode.InternalServerError, responseModel);
        }
    }

    private IActionResult StatusCode<T>(int ınternalServerError, BaseResponseModel<T> responseModel)
    {
        throw new NotImplementedException();
    }

    private IActionResult BadRequest<T>(BaseResponseModel<T> responseModel)
    {
        throw new NotImplementedException();
    }

    private IActionResult Ok<T>(BaseResponseModel<T> responseModel)
    {
        throw new NotImplementedException();
    }
}

namespace TelephoneDirectory.Core
{
    public class ControllerBase
    {
    }
}