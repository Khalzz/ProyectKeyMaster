using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelSongs : MonoBehaviour
{
    public string actualLevel;

    // actual level
    static public List<int> aNotes = new List<int>();
    static public List<int> sNotes = new List<int>();
    static public List<int> dNotes = new List<int>();
    static public List<int> fNotes = new List<int>();
    static public List<int> spaceNotes = new List<int>();
    static public List<int> jNotes = new List<int>();
    static public List<int> kNotes = new List<int>();
    static public List<int> lNotes = new List<int>();
    static public List<int> nNotes = new List<int>();

    
    // level test
    static public List<int> aLevelTest = new List<int>() {269, 334, 391, 451, 515, 583, 644, 705, 894, 921, 269, 334, 391, 451, 515, 583, 644, 705, 894, 921};
    static public List<int> sLevelTest = new List<int>() {269, 334, 391, 451, 515, 583, 644, 705, 894, 921, 269, 334, 391, 451, 515, 583, 644, 705, 894, 921};
    static public List<int> dLevelTest = new List<int>() {269, 334, 391, 451, 515, 583, 644, 705, 894, 921, 269, 334, 391, 451, 515, 583, 644, 705, 894, 921};
    static public List<int> fLevelTest = new List<int>() {269, 334, 391, 451, 515, 583, 644, 705, 894, 921, 269, 334, 391, 451, 515, 583, 644, 705, 894, 921};
    static public List<int> spaceLevelTest = new List<int>() {269, 334, 391, 451, 515, 583, 644, 705, 894, 921, 269, 334, 391, 451, 515, 583, 644, 705, 894, 921};
    static public List<int> jLevelTest = new List<int>() {269, 334, 391, 451, 515, 583, 644, 705, 894, 921, 269, 334, 391, 451, 515, 583, 644, 705, 894, 921};
    static public List<int> kLevelTest = new List<int>() {269, 334, 391, 451, 515, 583, 644, 705, 894, 921, 269, 334, 391, 451, 515, 583, 644, 705, 894, 921};
    static public List<int> lLevelTest = new List<int>() {269, 334, 391, 451, 515, 583, 644, 705, 894, 921, 269, 334, 391, 451, 515, 583, 644, 705, 894, 921};
    static public List<int> nLevelTest = new List<int>() {269, 334, 391, 451, 515, 583, 644, 705, 894, 921, 269, 334, 391, 451, 515, 583, 644, 705, 894, 921};
    // level test

    // level test 2
    static public List<int> aLevelTest2 = new List<int>() {};
    static public List<int> sLevelTest2 = new List<int>() {};
    static public List<int> dLevelTest2 = new List<int>() {6674, 6701, 6727, 6970, 6992, 7107, 7131, 7397, 7421, 7821, 7846, 8037, 8247, 8274,};
    static public List<int> fLevelTest2 = new List<int>() {1768, 1808, 1847, 1886, 1986, 2027, 2063, 2101, 2197, 2236, 2275, 2314, 2411, 2450, 2491, 2622, 2661, 2701, 2738, 2834, 2874, 2913, 2952, 3047, 3086, 3125, 3163, 3272, 3319, 3356, 3476, 3517, 3556, 3592, 3689, 3728, 3766, 3803, 3901, 3938, 3977, 4016, 4114, 4154, 4193, 4232, 4328, 4368, 4407, 4448, 4540, 4581, 4623, 4659, 4752, 4795, 4834, 4873, 4970, 5001, 5050, 5092, 5179, 5224, 5264, 5301, 5393, 5431, 5472, 5512, 5610, 5648, 5687, 5727, 5820, 5845, 5875, 6035, 6075, 6116, 6156, 6249, 6287, 6324, 6367, 6461, 6499, 6540, 6581, 6755, 6780, 6889, 6914, 7049, 7184, 7194, 7319, 7342, 7492, 7547, 7592, 7642, 7744, 7765, 7900, 7965, 7986, 8166, 8191, 8330, 8388, 8443, 8496};
    static public List<int> spaceLevelTest2 = new List<int>() {279, 489, 703, 918, 1130, 1343, 1554, 6007, 6808, 6834, 6861, 7689, 7713};
    static public List<int> jLevelTest2 = new List<int>() {1777, 1818, 1863, 1901, 1954, 2000, 2039, 2078, 2113, 2166, 2209, 2249, 2287, 2326, 2381, 2424, 2463, 2502, 2596, 2635, 2675, 2714, 2753, 2809, 2848, 2888, 2929, 2967, 3023, 3062, 3104, 3142, 3180, 3235, 3265, 3306, 3343, 3448, 3492, 3532, 3570, 3606, 3661, 3702, 3741, 3778, 3818, 3874, 3915, 3953, 3994, 4032, 4088, 4124, 4167, 4209, 4247, 4301, 4343, 4381, 4422, 4461, 4514, 4551, 4594, 4635, 4673, 4727, 4766, 4808, 4848, 4886, 4941, 4971, 5018, 5067, 5102, 5154, 5195, 5240, 5276, 5314, 5364, 5402, 5441, 5484, 5524, 5577, 5620, 5657, 5699, 5738, 5790, 5897, 5925, 6042, 6089, 6131, 6167, 6218, 6262, 6299, 6340, 6379, 6433, 6474, 6512, 6554, 6593, 6645, 6927, 6951, 7066, 7351, 7378, 7480, 7534, 7580, 7630, 7861, 7886, 8290, 8316, 8378, 8430, 8484, 8539, 8565};
    static public List<int> kLevelTest2 = new List<int>() {1927, 2142, 2355, 2531, 2567, 2783, 2997, 3209, 3382, 3418, 3636, 3846, 4062, 4276, 4490, 4703, 4915, 5128, 5342, 5551, 5764, 5953, 5980, 6193, 6408, 6620, 7010, 7033, 7142, 7167, 7433, 7460, 7780, 7803, 7998, 8022, 8208, 8232};
    static public List<int> lLevelTest2 = new List<int>() {};
    static public List<int> nLevelTest2 = new List<int>() {};
    
    // level test 2

    void Start()
    {   
        
    }

    void Update()
    {
        if (MainMenu.levelName == "Test")
        {
            aNotes = aLevelTest;
            sNotes = sLevelTest;
            dNotes = dLevelTest;
            fNotes = fLevelTest;
            spaceNotes = spaceLevelTest;
            jNotes = jLevelTest;
            kNotes = kLevelTest;
            lNotes = lLevelTest;
            nNotes = nLevelTest;
        }
        else if (MainMenu.levelName == "Test 2")
        {
            aNotes = aLevelTest2;
            sNotes = sLevelTest2;
            dNotes = dLevelTest2;
            fNotes = fLevelTest2;
            spaceNotes = spaceLevelTest2;
            jNotes = jLevelTest2;
            kNotes = kLevelTest2;
            lNotes = lLevelTest2;
            nNotes = nLevelTest2;
        }
    }
}
