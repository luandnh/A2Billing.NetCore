class NesopsOauth {

    baseAddress;

    constructor(addr) {
        var lastChar = addr[addr.length - 1];
        if (lastChar != "\\" && lastChar != '/')
            addr = addr + '/';
        this.baseAddress = addr;
    }

    checkToken(params) {
        params = params || {};
        var self = this;
        var token = self.getToken();
        if (token)
            $.ajax({
                url: this.baseAddress + "api/authorize/checkToken",
                async: false,
                headers: {
                    'Authorization': 'Bearer ' + token,
                },
                success: function (result) {
                    if (params.success)
                        params.success(result);
                },
                error: function (err) {
                    self.logout();
                    if (params.fail)
                        params.fail(err);
                }
            });
        else if (params.noToken)
            params.noToken();
    }

    redirectLogin(returnUrl) {
        location.replace(this.baseAddress + '?returnUrl=' + encodeURIComponent(returnUrl));
    }

    getToken() {
        return localStorage['nesops_access_token'];
    }

    setToken(token) {
        localStorage['nesops_access_token'] = token;
    }

    logout() {
        localStorage.removeItem('nesops_access_token');
    }

}
$(document).ready( function (e) {
    var nesops = new NesopsOauth(window.location.origin);
     nesops.checkToken({
         fail: (err) => {
             if (window.location.pathname !== "/Login/Admin" && window.location.pathname !== "/") {
                 window.location.replace(window.location.origin +"/Login/Admin");
             }
        },
         success: (result) => {
             if (window.location.pathname.includes("/Login/Admin") || window.location.pathname === "/" || window.location.pathname === "/Login" || window.location.pathname === "/Login/") {
                 window.location.replace(window.location.origin + "/Login/AdminSuccessful");
             }
             if (result.role != "Administrator") {
                 swal({
                     title: 'Warning!',
                     text: 'Your role is not Administrator! You will be moved to Login Page!',
                     icon: 'success'
                 }).then(function () {
                     window.location.replace(window.location.origin);
                 });
                 setTimeout(function () {
                     window.location.replace(window.location.origin);
                 }, 4000);
                 localStorage.clear();
                 return;
             }
             localStorage.setItem("CARDID", result.userId);
         },
         noToken: () => {
             if (window.location.pathname !== "/Login/Admin" && window.location.pathname !== "/" ) {
                 window.location.replace(window.location.origin + "/Login/Admin");
             }
         }
    })
});
