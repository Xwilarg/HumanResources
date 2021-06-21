namespace HumanResources.Character.Name
{
    public struct LetterInfo
    {
        public LetterInfo(float chance, LetterType type)
            => (Chance, Type) = (chance, type);

        public float Chance { get; }
        public LetterType Type { get; }
    }
}
