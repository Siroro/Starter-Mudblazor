using Microsoft.AspNetCore.Mvc.ModelBinding;

namespace Starter.Server.ViewModels.Authorization;

public class LogoutViewModel
{
    [BindNever]
    public string RequestId { get; set; }
}
