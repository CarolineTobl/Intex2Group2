using System;
using System.Collections.Generic;

namespace Intex2Group2.Data.Scaffolded;

public partial class Product
{
    public byte ProductId { get; set; }

    public string Name { get; set; } = null!;

    public short Year { get; set; }

    public short NumParts { get; set; }

    public short Price { get; set; }

    public string ImgLink { get; set; } = null!;

    public string PrimaryColor { get; set; } = null!;

    public string SecondaryColor { get; set; } = null!;

    public string Description { get; set; } = null!;

    public int CategoryMovies { get; set; }

    public int CategoryFlight { get; set; }

    public int CategoryVehicle { get; set; }

    public int CategoryOther { get; set; }

    public int CategoryMinifig { get; set; }

    public int CategoryAnimal { get; set; }

    public int CategoryBuilding { get; set; }

    public int CategoryPart { get; set; }

    public int CategoryCharacter { get; set; }

    public int CategoryColorful { get; set; }
}
