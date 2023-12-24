namespace Entities;

public abstract class BaseEntity
{
    /// <summary>
    /// Идентификатор сущности
    /// </summary>
    public int Id { get; set; }

    /// <summary>
    /// Дата и время создания в UTC
    /// </summary>
    public DateTime CreateDateTimeUtc { get; set; }

    /// <summary>
    /// Дата и время последнего изменения данных сущности в UTC
    /// </summary>
    public DateTime ModifyDateTimeUtc { get; set; }

    protected BaseEntity()
    {
        ModifyDateTimeUtc = CreateDateTimeUtc = DateTime.UtcNow;
    }

    /// <summary>
    /// Обновляет метку времени последнего изменения для объекта
    /// </summary>
    /// <remarks>
    /// Создана для того, чтобы для всех объектов метка времени обновлялась единообразно
    /// </remarks>
    public void UpdateModifiedTimestamp()
    {
        ModifyDateTimeUtc = DateTime.UtcNow;
    }
}
