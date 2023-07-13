/*


Deoxyribonucleic acid (DNA) is a chemical found in the nucleus of cells and carries the "instructions" for the development and functioning of living organisms.

If you want to know more: http://en.wikipedia.org/wiki/DNA

In DNA strings, symbols "A" and "T" are complements of each other, as "C" and "G". Your function receives one side of the DNA (string, except for Haskell); you need to return the other complementary side. DNA strand is never empty or there is no DNA at all (again, except for Haskell).

More similar exercise are found here: http://rosalind.info/problems/list-view/ (source)

Example: (input --> output)

"ATTGC" --> "TAACG"
"GTAT" --> "CATA"

Strings
Fundamentals
*/
using System;
using System.Collections.Generic;

public class DnaStrand
{
    public static string MakeComplement(string dna)
    {
        char[] complementArray = new char[dna.Length];

        for(int i = 0; i < dna.Length; i++)
        {
            char nucleotide = dna[i];
            char complementNucleotide = GetComplementNucleotide(nucleotide);

            complementArray[i] = complementNucleotide;
        }
        return new string(complementArray);
    }

    public static char GetComplementNucleotide(char nucleotide)
    {
        switch(nucleotide){
            case 'A':
                return 'T';
            case 'T':
                return 'A';
            case 'C':
                return 'G';
            case 'G':
                return 'C';
            default:
                return nucleotide;
        }
    }
}
