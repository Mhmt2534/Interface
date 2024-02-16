namespace Intrface
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //ICharacter character=new ICharacter(); //Wrong using
            ICharacter magic = new MagicManager();
            magic.Add();

            ICharacter skill= new SkillManager();
            skill.Update();

            Console.WriteLine("\n\n");

            /*
            MagicManager magicManager = new MagicManager();
            ProjectManager projectManager = new ProjectManager();
            projectManager.AddMagic(magicManager);
            */

            /*
            ICharacter magicManager = new MagicManager();
            ProjectManager projectManager = new ProjectManager();
            projectManager.Add(magicManager);
            */

            ProjectManager projectManager = new ProjectManager();
            projectManager.Add(new MagicManager());
            projectManager.Update(new SkillManager());

            projectManager.Add(new PowerManager());


        }


        interface ICharacter
        {
            void Add(); //imza
            void Update();

        }


        class MagicManager : ICharacter
        {
            public void Add()
            {
                Console.WriteLine("Magic Added");
            }

            public void Update()
            {
                Console.WriteLine("Magic Updated");
            }
        }

        class SkillManager : ICharacter
        {
            public void Add()
            {
                Console.WriteLine("Skill Added");
            }

            public void Update()
            {
                Console.WriteLine("Skill Updated");
            }
        }

        class PowerManager : ICharacter
        {
            public void Add()
            {
                Console.WriteLine("Power Added");
            }

            public void Update()
            {
                Console.WriteLine("Power Updated");
            }
        }




        class ProjectManager
        {
            /*
            public void AddMagic(MagicManager magic)
            {
                //Magic magic = new Magic();
                magic.Add();
            }   
            */

            public void Add(ICharacter character)
            {
                character.Add();
            }
            public void Update(ICharacter character)
            {
                character.Update();
            }

        }
        

    }
}
