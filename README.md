# ASPNetCoreIdentityCookie

| | Linux | Windows |
|:-:|:-:|:-:|

Using Cookie Middleware without ASP.NET Core Identity

ASP.NET Core provides cookie middleware which serializes a user principal into an encrypted cookie and then, on subsequent requests, validates the cookie, recreates the principal and assigns it to the User property on HttpContext. If you want to provide your own login screens and user databases you can use the cookie middleware as a standalone feature.

#1. build project
#2. login with detail: admin/123456