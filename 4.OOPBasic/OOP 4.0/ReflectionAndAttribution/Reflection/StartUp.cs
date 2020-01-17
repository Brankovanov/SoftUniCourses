using System;
using System.Reflection;
using System.Text;

namespace Reflection
{
    public class StartUp
    {
        static void Main()
        {
            var newPerson = new Person("Ivan", 23, 333.00, "Water fall director");
            ReflectingClassesAndMembers(newPerson);
            DinamicCreationOfInstances();
            ReflectingFields(newPerson);
            FieldConditionsChange();
            ReflectMethods(newPerson);
            InvokeNewMethod(newPerson);
        }

        public static void ReflectingClassesAndMembers(Person newPerson)
        {
            Type myType = typeof(Person);
            Type mySecondType = Type.GetType("Reflection.Person");
            string fullName = typeof(Person).FullName;
            string name = typeof(Person).Name;
            Type baseType = newPerson.GetType().BaseType;
            Type[] interfaceCollection = newPerson.GetType().GetInterfaces();


            Console.WriteLine(myType);
            Console.WriteLine(mySecondType);
            Console.WriteLine(fullName);
            Console.WriteLine(name);
            Console.WriteLine(baseType);

            for (var index = 0; index < interfaceCollection.Length; index++)
            {
                Console.WriteLine(interfaceCollection[index]);
            }
        }

        public static void DinamicCreationOfInstances()
        {
            var sbType = Type.GetType("System.Text.StringBuilder");

            Console.WriteLine(sbType);
            var sbInstance = (StringBuilder)Activator.CreateInstance(sbType, new object[] { 10 });

            var personType = Type.GetType("Reflection.Person");

            var personInstance = (Person)Activator.CreateInstance(personType, new object[] { "Dragan", 33, 150.00, "Worker" });

            Console.WriteLine(personInstance.Age);
            Console.WriteLine(personInstance.Name);
            Console.WriteLine(personInstance.Position);
            Console.WriteLine(personInstance.Salary);
            Console.WriteLine(personInstance.Relax());
            Console.WriteLine(personInstance.GoToWork());
            Console.WriteLine(personInstance.Sleep());

        }

        public static void ReflectingFields(Person newPerson)
        {
            FieldInfo info = newPerson.GetType().GetField("publicNumber");

            Console.WriteLine(info);

            FieldInfo[] publicFields = newPerson.GetType().GetFields();

            for (var index = 0; index < publicFields.Length; index++)
            {
                Console.WriteLine(publicFields[index]);
            }

            FieldInfo[] allFields = newPerson.GetType().GetFields(
                BindingFlags.Static |
                BindingFlags.Instance |
                BindingFlags.Public |
                BindingFlags.NonPublic);

            for (var index = 0; index < allFields.Length; index++)
            {
                Console.WriteLine(allFields[index]);
            }

            FieldInfo field = newPerson.GetType().GetField("publicNumber");
            var fieldName = field.Name;
            Type fieldType = field.FieldType;

            Console.WriteLine(fieldName);
            Console.WriteLine(fieldType.ToString());
        }

        public static void FieldConditionsChange()
        {
            Type testType = typeof(Person);
            var testPerson = (Person)Activator.CreateInstance(testType, new object[] { "Stamat", 33, 150.00, "Driver" });
            FieldInfo field = testPerson.GetType().GetField("publicNumber");
            field.SetValue(testPerson, "drun");
            var fieldValue = field.GetValue(testPerson);

            Console.WriteLine(fieldValue);
        }

        public static void ReflectMethods(Person newPerson)
        {
            MethodInfo[] publicMethods = newPerson.GetType().GetMethods();

            for (var index = 0; index < publicMethods.Length; index++)
            {
                Console.WriteLine(publicMethods[index]);
            }

            MethodInfo method = newPerson.GetType().GetMethod("GoToWork");
            Console.WriteLine(method.ToString());

            ParameterInfo[] parameters = newPerson.GetType().GetMethod("Calculate").GetParameters();
            for (var index = 0; index < parameters.Length; index++)
            {
                Console.WriteLine(parameters[index].ParameterType);
                Console.WriteLine(parameters[index].Name);
            }

        }
       
        public static void InvokeNewMethod(Person newPerson)
        {
            var sbType = Type.GetType("System.Text.StringBuilder");

            Console.WriteLine(sbType);
            var sbInstance = (StringBuilder)Activator.CreateInstance(sbType, new object[] { 10 });

            var personType = Type.GetType("Reflection.Person");

            var personInstance = (Person)Activator.CreateInstance(personType, new object[] { "Dragan", 33, 150.00, "Worker" });

            Console.WriteLine(personInstance.GetType().GetMethod("Calculate").Invoke(personInstance, new object[] { 1, 1.0 }));
        }
    }
}
