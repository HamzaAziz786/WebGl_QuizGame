using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameController : MonoBehaviour
{
    public Animator _PlayerAnimator;
    public List<Avatar> avatarsList;
    public List<GameObject> _Players;

    private void Start()
    {
        _PlayerAnimator.avatar = avatarsList[GameMAnager.SelectCharacterChoice];
        _Players[GameMAnager.SelectCharacterChoice].SetActive(true);
    }
}
