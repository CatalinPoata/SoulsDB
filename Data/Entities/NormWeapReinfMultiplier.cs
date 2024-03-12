namespace SoulsDB.Data.Entities
{
    public class NormWeapReinfMultiplier : BaseEntity
    {
        public byte UpgradeLevel { get; set; } = default!;
        public float PhysicalAR { get; set; }
        public float MagicAR { get; set; }
        public float FireAR { get; set; }
        public float LightningAR { get; set; }
        public float STRScaling { get; set; }
        public float DEXScaling { get; set; }
        public float INTScaling { get; set; }
        public float FAIScaling { get; set; }
    }
}