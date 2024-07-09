using 景区系统.Core.Entity;

namespace 景区系统.Application;

/// <summary>
/// 系统服务接口
/// </summary>
public class SystemAppService : IDynamicApiController
{
    private readonly ISystemService _systemService;
    private readonly IRepository<Menu> repository;
    public SystemAppService(ISystemService systemService, IRepository<Menu> repository)
    {
        _systemService = systemService;
        this.repository = repository;
    }

    /// <summary>
    /// 获取系统描述
    /// </summary>
    /// <returns></returns>
    public string GetDescription()
    {
        return _systemService.GetDescription();
    }
}
