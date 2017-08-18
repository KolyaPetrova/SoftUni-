package LAB.Problems;

import java.io.IOException;
import java.nio.file.Files;
import java.nio.file.Path;
import java.nio.file.Paths;
import java.util.Collections;
import java.util.List;

public class SortLines {
    public static void main(String[] args) {
        String inputPath = "..\\FilesAndDirectories\\input.txt";
        String outputPath = "..\\FilesAndDirectories\\SortLines.txt";

        Path pathIn = Paths.get(inputPath);
        Path pathOut = Paths.get(outputPath);

        try {
            List<String> lines = Files.readAllLines(pathIn);
            Collections.sort(lines);
            Files.write(pathOut,lines);
        } catch (IOException e) {
            e.printStackTrace();
        }

    }
}
