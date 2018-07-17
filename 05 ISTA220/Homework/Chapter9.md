### Author: Justin Mourfield
### Date : March 18, 2018
### Title: chapter09

1. enum Rank: byte{PVT=1, PF2, PFC, SPC, CPL=4 SGT, SSG, SFC, MSG, 1SG=MSG SGM, CSM}
2. Rank Justin = Rank.SSG;
3.{PVT=1, PF2=2, PFC=3, SPC=4, CPL=4 SGT, SSG, SFC, MSG, 1SG=MSG SGM, CSM
4. You designate a data type after you specify the enum name/type. it defaults to INT.
5. Structs are stored on the stack as are enums because they are both considered value types. 
6. struct DOD {public string Army, Air Force, Navy, Marines;}
7. You cannot declare a default constructor for a struct because the compiler always generates one. The default constructor of a struct sets fields to null, 0, or false. You cannot initialize fields in structs at their point of declaration. it must be done with incoming args in the form of constructors. 
8.CIL is common intermediate language which are the instructions that are stored in an assembly. Common language runtime converts the CIL into machine instructions that a processor uses. 