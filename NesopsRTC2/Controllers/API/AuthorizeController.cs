using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using NesopsRTC2.Models;
using NesopsService.Base.Model;
using NesopsService.Services;

namespace NesopsRTC2.Controllers.API
{
    [Route("api/[controller]")]
    [ApiController]
    public class AuthorizeController : ControllerBase
    {
        private readonly AuthorizeService _authorizeService;
        public AuthorizeController(AuthorizeService authorizeService)
        {
            _authorizeService = authorizeService;
        }
        private AuthorizeModel _authorizeModel;
        [HttpPost]
        public async Task<IActionResult> Login([FromBody]LoginModel model)
        {
            _authorizeModel = new AuthorizeModel();
            await AspUserCredentials(model);

            if (!_authorizeModel.valid)
            {
                return Unauthorized(new BaseResponseModel<object> { success = false, message = "Username or password is wrong!", errors = _authorizeModel.errors, code = (int)HttpStatusCode.Unauthorized });
            }
            var res = _authorizeService.GetTokenResponse(_authorizeModel.ticket);
            return Ok(new BaseResponseModel<IDictionary<string, object>> { message = "Login Successful", data = res, code = (int)HttpStatusCode.OK });
        }
        private async Task AspUserCredentials(LoginModel model)
        {
            var ticket = await _authorizeService.GetAuthenticateTicketAsync(model.username, model.password);
            if (ticket == null)
            {
                _authorizeModel.SetError("username_password_error", "Invalid username or password");
                _authorizeModel.Rejected();
                return;
            }
            _authorizeModel.Validated(ticket);
            return;
        }
        [HttpPost]
        [Route("root")]
        public async Task<IActionResult> RootLogin([FromBody]LoginModel model)
        {
            _authorizeModel = new AuthorizeModel();
            await AspUserRootCredentials(model);

            if (!_authorizeModel.valid)
            {
                return Unauthorized(new BaseResponseModel<object> { success = false, message = "Username or password is wrong!", errors = _authorizeModel.errors, code = (int)HttpStatusCode.Unauthorized });
            }
            var res = _authorizeService.GetTokenResponse(_authorizeModel.ticket);
            return Ok(new BaseResponseModel<IDictionary<string, object>> { message = "Login Successful", data = res, code = (int)HttpStatusCode.OK });
        }
        private async Task AspUserRootCredentials(LoginModel model)
        {
            var ticket = await _authorizeService.GetRootAuthenticateTicketAsync(model.username, model.password);
            if (ticket == null)
            {
                _authorizeModel.SetError("username_password_error", "Invalid username or password");
                _authorizeModel.Rejected();
                return;
            }
            _authorizeModel.Validated(ticket);
            return;
        }
        [HttpGet("checkToken")]
        [Authorize]
        public IActionResult CheckToken()
        {
            var resp = new CheckTokenResponseViewModel(this.User);
            return Ok(resp);
        }
    }
}