using System;
using System.Collections.Generic;

namespace Elements_Reloaded
{
    public static class GameDialogue
    {
        private static readonly string[] _levelOrder = GameController.ArrangeLevels();

        public static string GetLevelName(int level)
        {
            Dictionary<int, string> LevelNames =
                new Dictionary<int, string>
                {
                    { 1, _levelOrder[0] },
                    { 2, _levelOrder[1] },
                    { 3, _levelOrder[2] },
                    { 4, _levelOrder[3] },
                    { 5, _levelOrder[4] },
                    { 6, _levelOrder[5] },
                    { 7, _levelOrder[6] },
                    { 8, "Lightning Tower" },
                    { 9, _levelOrder[7] },
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
                "a raged man charged at the hero...",

                "Now, more determined than ever, {} traversed faster, hoping the answer lie " +
                "ahead. They were emotionally weakened by witnessing what the darkness had done" +
                " to their friends. Suddenly, {} felt a strong force. A presence, distant but " +
                " there. Then it went away. 'What was that?' said the hero. Could I be getting" +
                " closer to the source? Will I be victorious soon?' The presence returned, this " +
                "time saying... 'ultimate power...'",

                "'Man, this feels weird' {} stated. They were getting closer to a force they had" +
                " never encounted. It was clear that they were getting closer to the source of it" +
                " all. As the horizon became more clear, {} saw a large tower. It looked as if " +
                "sparks randomly surrounded it. 'I don't know what element habits this place' the " +
                "warrior said, 'but it can't be good...'",

                "The two bosses began to merge into one! " +
                "With both elements changed, this new monster emitted jolts of lightning!",

                "'MERE MORTAL' it said, 'YOU WILL SUBMIT TO THE ULTIMATE POWER!' {} was ready to " +
                "fight back. 'Who are you?' they replied. 'And why are you here?' 'I AM ELEMATRIX' " +
                "shouted the voice, 'AND YOU WILL LEARN TO OBEY ME!' 'I will never let you rule!' " +
                "{} shouted. 'I will save my friends and restore humanity!' 'IF YOU WILL NOT COME " +
                "WILLINGLY...THEN I SHALL SEND AN ARMY OF YOUR WEKANESS AT YOU. HAHAHA...'",

                "'Show yourself!' {} cried out to Elematrix. 'I will defeat you and save the world!' " +
                "'IS THAT SO?' Elematrix replied. 'YOU WISH TO BE DEFEATED SO SOON?' The hero was not " +
                "in th mood for games. 'You will face me! Right here, right now!' It was at that point " +
                "that the world around {} began to change... The sky darkened, the water disappeared, and " +
                "the ground shifted to something unknown. Alone and confused, {} yelled 'What is going on?!? " +
                "Where am I? Answer me!' 'IF YOU WANT TO FACE ME, YOU WILL DO SO ON MY FIELD' Elematrix " +
                "answered. 'BUT FIRST...I WILL THROW EVERY TYPE OF ELEMENT YOUR WAY. AND IF YOU SURVIVE, " +
                "I'LL BE GLAD TO ANNIHILATE YOU MYSELF!'",

                "All of the sudden, the elements go wild... " +
                "A strange anomoly appears, and it looks...so...menacing! " +
                "'It's time...to fight...ELEMATRIX!"
            };

            return IntroDialogue[level-1];
        }
    }
}
