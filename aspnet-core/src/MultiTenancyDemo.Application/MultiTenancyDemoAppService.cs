using System;
using System.Collections.Generic;
using System.Text;
using MultiTenancyDemo.Localization;
using Volo.Abp.Application.Services;

namespace MultiTenancyDemo;

/* Inherit your application services from this class.
 */
public abstract class MultiTenancyDemoAppService : ApplicationService
{
    protected MultiTenancyDemoAppService()
    {
        LocalizationResource = typeof(MultiTenancyDemoResource);
    }
}
