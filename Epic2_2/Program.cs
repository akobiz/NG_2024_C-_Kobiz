using Epic2_2.Data;
using Epic2_2.Services;

var data = DataSource.Games;
var gameHandlerService = new GameHandlerService();
gameHandlerService.HandleGameService(data);