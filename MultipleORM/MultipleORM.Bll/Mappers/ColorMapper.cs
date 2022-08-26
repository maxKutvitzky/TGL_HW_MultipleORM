using MultipleORM.Bll.Interfaces.Entities;
using MultipleORM.Dal.Interfaces.Entities;

namespace MultipleORM.Bll.Mappers;

public static class ColorMapper
{
    public static BllColor ToBllColor(this Color color)
    {
        return new BllColor()
        {
            Id = color.Id,
            Name = color.Name,
        };
    }

    public static Color ToColor(this BllColor bllColor)
    {
        return new Color()
        {
            Id = bllColor.Id,
            Name = bllColor.Name
        };
    }
}