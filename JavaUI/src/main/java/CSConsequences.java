import com.sun.jna.Library;
import com.sun.jna.Native;
public class CSConsequences {
    static String dllPath =  "C:\\Programs\\Git\\Repos\\multi-language-mixer\\CSConsequences\\HelloWorld\\bin\\Release\\net8.0\\win-x64\\native\\HelloWorld.exe";
    public static final goDataset csq =  Native.load(dllPath, goDataset.class);

    public interface goDataset extends Library{
        int GoInland(String words);
    }

    public static int Compute(String filepath, String terrainpath,String nsiPath, String output, int espg){
        return csq.GoInland(filepath, terrainpath,nsiPath,output,espg);
    }
}
