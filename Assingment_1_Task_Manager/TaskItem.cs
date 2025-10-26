
public class TaskItem {
    public Guid Id { 
        get; 
        set; }
    public string Description { 
        get; 
        set; }
    public bool IsCompleted { 
        get; 
        set; }
}

// not sure how to make the API part
// GET /api/tasks
// POST /api/tasks
