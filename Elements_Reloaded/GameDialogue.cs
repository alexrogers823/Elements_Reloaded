using System;
using System.Collections.Generic;

namespace Elements_Reloaded
{
    public static class GameDialogue
    {
        private static readonly string[] _levelOrder = ArrangeLevels();

        public static string GetLevelName(int level)
        {
            Dictionary<int, string> LevelNames =
                new Dictionary<int, string>
                {
                    { 1, "test" },
                    { 2, "test" },
                    { 3, "test" },
                    { 4, "test" },
                    { 5, "test" },
                    { 6, "test" },
                    { 7, "test" },
                    { 8, "Lightning Tower" },
                    { 9, "test" },
                    { 10, "Element Dimension" },
                };

            return LevelNames[level];
        }

        public static string GetLevelIntro(int level)
        {
            string[] IntroDialogue = new string[]
            {
                "Long ago, the world was balanced by the elemental" +
                "forces that were bestowed, in equal strength and harmony." +
                "But an evil entity took advantage of such strengths and " +
                "created chaos, unleashing havoc by corrupting the guardians" +
                "of the elements and the ones who serve them." +
                "Now, it is up to {} to restore order, and bring an end to great" +
                "evil once and for all...",

                "'My friends have been corrupted!' {} realized. There was something" +
                "wrong with them. Never had other tribes been so hostile to each other." +
                "Not for centuries. 'There must be something in the air,' the warrior" +
                "thought, 'or the way the stars have aligned.' Confused, and determined" +
                "to seek the issue, they carried on...",

                "'This seems odd', {} said. The approaching area felt so familiar." +
                "The symbols on the walls were identical to their own. Suddenly {}" +
                "realized. 'Oh no!' the warrior said. 'My own people have been corrupted!'",

                "{}'s heart became filled with sadness after fighting their own people." +
                "'I will end this evil presence!' the hero declared. 'Then all will return to" +
                "normal.' But as {} was pondering, a shadow appeared... A force that had" +
                "the exact opposite sign. {} now knew that they would be going up against" +
                "their weaknesses. And it wouldn't be easy...",

                "Now {} realized that they were getting closer to the great force that" +
                "corrupted the world. Having defeated each of the elements, their confidence" +
                "seemed to get higher. As {} kept walking, they noticed symbols that they" +
                "had already come across. 'Is this a place I already visited?' they wondered," +
                "'Or...a stronger tribe of an element before?' Ready for anything, {}" +
                "carried on...",

                "{} hadn't truly realized how many people were corrupted by this dark spirit." +
                "It was clear that the people of this world needed help to overcome this. But {}" +
                "still wondered, was why this was still happening? Then, just over the hill, " +
                "a raged man charged at the hero..."
            };

            return IntroDialogue[level-1];
        }

        public static string ArrangeLevels(string elementType)
        {

        }
    }
}
