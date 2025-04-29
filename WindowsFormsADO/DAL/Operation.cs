using System;

namespace WindowsFormsADO.DAL
{
    public class Operation
    {
        //ID операции
        public int OperationId { get; set; }
        //ID топлива
        public int FuelId { get; set; }
        //ID емкости
        public int TankId { get; set; }
        //Приход/Расход
        public float? Inc_Exp { get; set; }
        //Дата операции
        public DateTime Date { get; set; }
        //ссылка на виды топлива

    }
}
