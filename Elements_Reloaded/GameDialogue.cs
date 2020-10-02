using System;
using System.Collections.Generic;

namespace Elements_Reloaded
{
    public static class GameDialogue
    {
        
        private static readonly Random random = new Random();

        

        public static string GetEnemyIntro()
        {
            int Index = random.Next(6);
            string[] Introductions = new string[6]
            {
                "A {0} stands in your way! Prepare for battle!",
                "Your path is being blocked by a {0}! Can you take him?",
                "Look here, a {0} is sizing you up! Kill them",
                "You've stumbled across a {0}, and he looks dangerous!",
                "All of a sudden a {0} approaches! Stand your ground!",
                "You're face to face with a {0}! And he's out for blood"
            };

            return Introductions[Index];
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
                "Now, it is up to {0} to restore order, and bring an end to great" +
                "evil once and for all...",

                "'My friends have been corrupted!' {0} realized. There was something" +
                "wrong with them. Never had other tribes been so hostile to each other." +
                "Not for centuries. 'There must be something in the air,' the warrior" +
                "thought, 'or the way the stars have aligned.' Confused, and determined" +
                "to seek the issue, they carried on...",

                "'This seems odd', {0} said. The approaching area felt so familiar." +
                "The symbols on the walls were identical to their own. Suddenly {0}" +
                "realized. 'Oh no!' the warrior said. 'My own people have been corrupted!'",

                "{0}'s heart became filled with sadness after fighting their own people." +
                "'I will end this evil presence!' the hero declared. 'Then all will return to" +
                "normal.' But as {0} was pondering, a shadow appeared... A force that had" +
                "the exact opposite sign. {0} now knew that they would be going up against" +
                "their weaknesses. And it wouldn't be easy...",

                "Now {0} realized that they were getting closer to the great force that" +
                "corrupted the world. Having defeated each of the elements, their confidence" +
                "seemed to get higher. As {0} kept walking, they noticed symbols that they" +
                "had already come across. 'Is this a place I already visited?' they wondered," +
                "'Or...a stronger tribe of an element before?' Ready for anything, {0}" +
                "carried on...",

                "{0} hadn't truly realized how many people were corrupted by this dark spirit." +
                "It was clear that the people of this world needed help to overcome this. But {0}" +
                "still wondered, was why this was still happening? Then, just over the hill, " +
                "a raged man charged at the hero...",

                "Now, more determined than ever, {0} traversed faster, hoping the answer lie " +
                "ahead. They were emotionally weakened by witnessing what the darkness had done" +
                " to their friends. Suddenly, {0} felt a strong force. A presence, distant but " +
                " there. Then it went away. 'What was that?' said the hero. Could I be getting" +
                " closer to the source? Will I be victorious soon?' The presence returned, this " +
                "time saying... 'ultimate power...'",

                "'Man, this feels weird' {0} stated. They were getting closer to a force they had" +
                " never encounted. It was clear that they were getting closer to the source of it" +
                " all. As the horizon became more clear, {0} saw a large tower. It looked as if " +
                "sparks randomly surrounded it. 'I don't know what element habits this place' the " +
                "warrior said, 'but it can't be good...'",

                "The two bosses began to merge into one! " +
                "With both elements changed, this new monster emitted jolts of lightning!",

                "'MERE MORTAL' it said, 'YOU WILL SUBMIT TO THE ULTIMATE POWER!' {0} was ready to " +
                "fight back. 'Who are you?' they replied. 'And why are you here?' 'I AM ELEMATRIX' " +
                "shouted the voice, 'AND YOU WILL LEARN TO OBEY ME!' 'I will never let you rule!' " +
                "{0} shouted. 'I will save my friends and restore humanity!' 'IF YOU WILL NOT COME " +
                "WILLINGLY...THEN I SHALL SEND AN ARMY OF YOUR WEKANESS AT YOU. HAHAHA...'",

                "'Show yourself!' {0} cried out to Elematrix. 'I will defeat you and save the world!' " +
                "'IS THAT SO?' Elematrix replied. 'YOU WISH TO BE DEFEATED SO SOON?' The hero was not " +
                "in th mood for games. 'You will face me! Right here, right now!' It was at that point " +
                "that the world around {0} began to change... The sky darkened, the water disappeared, and " +
                "the ground shifted to something unknown. Alone and confused, {0} yelled 'What is going on?!? " +
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
