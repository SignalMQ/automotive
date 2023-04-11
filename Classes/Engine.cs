namespace automotive.Classes
{
    public class Engine
    {
        private const int MIN_VALUE = 0;   //минимальное
        private const int MAX_VALUE = 100; //максимальное

        /// <summary>
        /// Уровень топлива
        /// </summary>
        public struct FuelLevel
        {
            private int Level = 0;

            public FuelLevel(int level)
            {
                if(level < MIN_VALUE || level > MAX_VALUE)
                {
                    throw new ArgumentOutOfRangeException();
                }
                else
                {
                    Level = level;
                }
            }
        }
        /// <summary>
        /// Уровень воды
        /// </summary>
        public struct WaterLevel
        {
            private int Level = 0;

            public WaterLevel(int level)
            {
                if (level < MIN_VALUE || level > MAX_VALUE)
                {
                    throw new ArgumentOutOfRangeException();
                }
                else
                {
                    Level = level;
                }
            }
        }
        /// <summary>
        /// Уровень двительного масла
        /// </summary>
        
    }
}
