package kolev.exam.dto.branches;

import com.google.gson.annotations.Expose;
import kolev.exam.entities.Town;

public class BranchImportJsonDto {
    @Expose
    private String name;

    @Expose
    private String town;

    public BranchImportJsonDto() {
    }

    public String getName() {
        return name;
    }

    public void setName(String name) {
        this.name = name;
    }

    public String getTown() {
        return town;
    }

    public void setTown(String town) {
        this.town = town;
    }
}
