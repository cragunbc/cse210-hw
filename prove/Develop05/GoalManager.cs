public class GoalManager
{
    private int _score;
    private List<Goal> _goals = new();


    public GoalManager()
    {

    }

    public void DisplayPlayerInfo()
    {

    }


    public void ListGoalDetails()
    {   // *format output with counter
        // FOREACH goal in goals
        //      goal.GetDetailsString()
    }

    public void CreateGoal()
    {
        // Menu...
        // case 1:
        //      name = GET What is the name?
        //      description = GET what is the description?
        //      points = GET What is the points?
        //      SimpleGoal(name, description, points)
        //      
    }

    public void RecordEvent()
    {
        // score += goal.recordevent()
    }

    public void SaveGoals()
    {
        // GET filepath
        // using(StreamWriter io = new(filepath, true))
        // {
        //      FOREACH goal in goals
        //          *PUT goal.GetSaveString()  *io.WriteLine()
    }

    public void LoadGoals()
    {
        
    }
}