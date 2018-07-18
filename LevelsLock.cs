using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;

public class LevelsLock : MonoBehaviour {

    public string Text;


    private string Folder = @"C:\\UnityGame\\Progress\\level";
    private string txt = @"C:\\UnityGame\\Progress\\level\\ActualLevel.txt";

    private void Start()
    {
        SaveLevels(Text);
    }

    public void SaveLevels(string Ms)
    {


        //creando directorio
        try
        {
            if (Directory.Exists(Folder))
            {
                Debug.Log("yah existe, continuemos");
            }
            else
            {
                Directory.CreateDirectory(Folder);
                Debug.Log("Directorio creado, continuemos");
            }

        }catch(System.Exception e)
        {
            Debug.Log("Error: " + e.Message);
        }


        //creando archivo .txt
        try
        {
            if (File.Exists(txt))
            {
                File.Delete(txt);

                FileStream stream = new FileStream(txt, FileMode.OpenOrCreate, FileAccess.Write);
                StreamWriter writer = new StreamWriter(stream);
                writer.WriteLine(Ms);
                writer.Close();

                Debug.Log("Has guardado " + Ms);

            }
            else
            {
                FileStream stream = new FileStream(txt, FileMode.OpenOrCreate, FileAccess.Write);
                StreamWriter writer = new StreamWriter(stream);
                writer.WriteLine(Ms);
                writer.Close();

                Debug.Log("Has guardado " + Ms);
            }
        }
        catch (System.Exception a)
        {
            Debug.Log("Error: " + a.Message);
        }

    }

}
