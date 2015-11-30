using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class MainMenu : MonoBehaviour {

    public GameObject CanvasMenu;

    //будет 3 положения: начальное, главное меню, меню pvp
    enum MenuState
    {
        Initial = 0,
        Main = 1,
        Multiplayer = 2,
    }

    // текущее положение камеры
    MenuState mCurrentMenuState;

    // повороты камеры при различных положениях
    Vector3[] mStatesRotations = new Vector3[]{
		new Vector3(30, 0, 0),
		new Vector3(-25, 0, 0),
		new Vector3(-25, 90, 0)
	};
    // положения основного меню при различных положениях камеры
    Vector3[] mMainMenuPositions = new Vector3[]{
		new Vector3(0.5f, -0.29f, 0),
		new Vector3(0.5f, 0.39f, 0),
		new Vector3(-0.25f, 0.39f, 0),
	};
    // положения меню сетевой игры при различных положениях камеры
    Vector3[] mMultiplayerMenuPositions = new Vector3[]{
		new Vector3(1.26f, -0.17f, 0),
		new Vector3(1.26f, 0.27f, 0),
		new Vector3(0.5f, 0.50f, 0),
	};
    // скорость вращения камеры
    public float mSmooth = 2.0f;
    GameObject panelMainMenu;
    GameObject panelMultiplayerMenu;

    void Start()
    {
        // устанавливается начальные положения меню и камеры
        mCurrentMenuState = MenuState.Main;
        panelMainMenu = GameObject.Find("panelMainMenu");
        panelMainMenu.transform.position = TranslateCoords(mMainMenuPositions[(int)MenuState.Initial]);
        panelMultiplayerMenu = GameObject.Find("panelMultiplayerMenu");
        panelMultiplayerMenu.transform.position = TranslateCoords(mMultiplayerMenuPositions[(int)MenuState.Initial]);

        if (GameOptions.Instance == null)
        {
            GameObject.Find("GameOptions").AddComponent<GameOptions>();
        }
    }

    // преобразование координат относительных в экранные координаты
    public Vector3 TranslateCoords(Vector3 vec)
    {
        return new Vector3(vec.x * Screen.width, vec.y * Screen.height, vec.z);
    }
}
