package hiberspring.hiberspring.io;

public interface Writer {

    void println(String content);

    void println(String format, Object... args);
}