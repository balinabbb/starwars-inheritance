namespace StarWars.Sides
{
    interface IWarriorSource
    {
        /// <summary>
        /// A Warrirors tulajdonságot be kell állítania, az all warrior tömbből kiválasztva a megfelelő elemeket.
        /// A megfelelő elemeket a "side" paraméter határozza meg.
        /// </summary>
        /// <param name="all">Megkapja az összes warriort ami beolvasásra került a fájlból.</param>
        /// <param name="side">Megkapja, hogy melyik oldal információit kell kinyerni</param>
        IWarriorSource Initialize(Warrior[] all, bool side);
        /// <summary>
        /// Tartalmazza az összes oldalhoz tartozó warriort, és bármikor végig iterálható
        /// </summary>
        Warrior[] Warriors { get; }
        /// <summary>
        /// Visszaadja a következő warriort. Nem adhat vissza ismétlődő elemeket.
        /// </summary>
        /// <returns></returns>
        Warrior Next();
    }
}
