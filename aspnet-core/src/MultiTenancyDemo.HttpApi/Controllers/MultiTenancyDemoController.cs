using MultiTenancyDemo.Localization;
using Volo.Abp.AspNetCore.Mvc;

namespace MultiTenancyDemo.Controllers;

/* Inherit your controllers from this class.
 */
public abstract class MultiTenancyDemoController : AbpControllerBase
{
    protected MultiTenancyDemoController()
    {
        LocalizationResource = typeof(MultiTenancyDemoResource);
    }
}
