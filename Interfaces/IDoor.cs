using TheLegendOfZelda.LevelLoading;
using TheLegendOfZelda.Shared;

namespace TheLegendOfZelda.Interfaces;

public interface IDoor : IBlock
{
    public string AdjacentRoomId { get; set;  }
    public Direction FacingDirection { get; set; }
    public void InitializeAdjacencyInformation(string roomId);

    public void InitializeFacingDirection(Room room);
}