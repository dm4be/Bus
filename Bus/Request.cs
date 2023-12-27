using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bus
{
    public interface Request
    {
        // Условная базовая стоимость обработки запроса.
        double GetCost();

        // Возвращает запрос с установленным
        Request Handle(bool success, HandleError error);

        // Был ли обработан данный запрос.
        bool IsHandled();

        HandleError GetError();
    }

    public enum HandleError
    {
        // Ошибка отсутствует
        None = 0,
        // Кончились запрашиваемые ресурсы
        ResourceIsOver = 1,
        // Обработчик находится в состоянии, непригодном для обработки запроса.
        HandlerIsTakeRest = 2
    }
}

