using System;
using System.Collections.Generic;

class ScriptureLibrary
{
    public static List<Scripture> GetScriptures()
    {
        return new List<Scripture>
        {
            new Scripture(
                "Trust in the Lord with all thine heart and lean not unto thine own understanding",
                new Reference("Proverbs", 3, 5, 6)
            ),
            new Scripture(
                "I can do all things through Christ which strengtheneth me",
                new Reference("Philippians", 4, 13)
            ),
            new Scripture(
                "For God so loved the world that he gave his one and only Son, that whoever believes in him shall not perish but have eternal life.",
                new Reference("John", 3, 16)
            ),
            new Scripture(
                "In the beginning God created the heavens and the earth.",
                new Reference("Genesis", 1, 1)
            ),
            new Scripture(
                "Be strong and courageous. Do not be afraid; do not be discouraged, for the Lord your God will be with you wherever you go.",
                new Reference("Joshua", 1, 9)
            ),
            new Scripture("For I know the plans I have for you, declares the Lord, plans to prosper you and not to harm you, plans to give you hope and a future.",
                new Reference("Jeremiah", 29, 11)
            ),
            new Scripture(
                "And we know that in all things God works for the good of those who love him, who have been called according to his purpose.",
                new Reference("Romans", 8, 28)
            ),
            new Scripture(
                "The Lord is my shepherd; I shall not want. He maketh me to lie down in green pastures: he leadeth me beside the still waters.",
                new Reference("Psalm", 23, 1, 2)
            ),
            new Scripture(
                "And charity suffereth long, and is kind, and envieth not, and is not puffed up, seeketh not her own, is not easily provoked, thinketh no evil, and rejoiceth not in iniquity but rejoiceth in the truth, beareth all things, believeth all things, hopeth all things, endureth all things.",
                new Reference("Moroni", 7, 45)
            ),
        };
    }
}