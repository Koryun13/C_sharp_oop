namespace Packt.Shared;

[System.Flags]
public enum AncientWonders : byte
{
    None =                      0b_0000_0000,
    GreatPyramidofGiza  =       0b_0000_0001,
    HangingGardenofBabylon  =   0b_0000_0010,
    StatueofZeusAtOlympia  =    0b_0000_0100,
    TempleOfArtemisAtEphesus  = 0b_0000_1000,
    MausolemAtHlicarnassus  =   0b_0001_0000,
    ColossusofRhodes  =         0b_0010_0000,
    LightouseofAlexandria  =    0b_0100_0000
}

