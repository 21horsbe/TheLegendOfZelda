﻿using TheLegendOfZelda.AbstractClasses;
using TheLegendOfZelda.Interfaces;
using TheLegendOfZelda.Items;
using TheLegendOfZelda.Projectiles;
using TheLegendOfZelda.Shared;
using TheLegendOfZelda.Shared.Managers;
using Microsoft.Xna.Framework;
using System;

namespace TheLegendOfZelda.States;
public class GoriyaMainState : AbstractPlayerState
{
    private int _movingCounter;
    private int _lastMovingCounter;
    private int _spriteFrameOneRow;
    private int _spriteFrameTwoRow;
    private readonly int _spriteFrameOneColumn;
    private readonly int _spriteFrameTwoColumn;
    private Direction _lastDirection;
    private int _timeToMove;

    private const int Height = 16 * Globals.GlobalSizeMult;
    private const int Width = 16 * Globals.GlobalSizeMult;
    public GoriyaMainState(IPlayer player)
    {
        MyPlayer = player;
        _movingCounter = 0;
        _spriteFrameOneRow = 1;
        _spriteFrameTwoRow = 1;
        _spriteFrameOneColumn = 1;
        _spriteFrameTwoColumn = 2;
        MyPlayer.CurrentSprite = SpritesheetFactory.Instance.CreateGoriyaSprite();
        MyPlayer.CurrentSprite.SetFrame(_spriteFrameOneRow, _spriteFrameOneColumn);
        _lastDirection = Direction.Down;
        _timeToMove = 0;
    }
    public override void MoveDown()
    {
        if (_timeToMove != 0) return;
        int prevRow = _spriteFrameOneRow;
        _spriteFrameOneRow = 1;
        _spriteFrameTwoRow = 1;
        MyPlayer.MovingDirection = Direction.Down;
        _lastDirection = Direction.Down;
        MyPlayer.YPosition += StepSize;
        _movingCounter++;
        if (prevRow != _spriteFrameOneRow) MyPlayer.CurrentSprite.SetFrame(_spriteFrameOneRow, _spriteFrameOneColumn);
    }
    public override void MoveUp()
    {
        if (_timeToMove != 0) return;
        int prevRow = _spriteFrameOneRow;
        _spriteFrameOneRow = 2;
        _spriteFrameTwoRow = 2;
        MyPlayer.MovingDirection = Direction.Up;
        _lastDirection = Direction.Up;
        MyPlayer.YPosition -= StepSize;
        _movingCounter++;
        if (prevRow != _spriteFrameOneRow) MyPlayer.CurrentSprite.SetFrame(_spriteFrameOneRow, _spriteFrameOneColumn);
    }
    public override void MoveLeft()
    {
        if (_timeToMove != 0) return;
        int prevRow = _spriteFrameOneRow;
        _spriteFrameOneRow = 3;
        _spriteFrameTwoRow = 3;
        MyPlayer.MovingDirection = Direction.Left;
        _lastDirection = Direction.Left;
        MyPlayer.XPosition -= StepSize;
        _movingCounter++;
        if (prevRow != _spriteFrameOneRow) MyPlayer.CurrentSprite.SetFrame(_spriteFrameOneRow, _spriteFrameOneColumn);
    }
    public override void MoveRight()
    {
        if (_timeToMove != 0) return;
        int prevRow = _spriteFrameOneRow;
        _spriteFrameOneRow = 4;
        _spriteFrameTwoRow = 4;
        MyPlayer.MovingDirection = Direction.Right;
        _lastDirection = Direction.Right;
        MyPlayer.XPosition += StepSize;
        _movingCounter++;
        if (prevRow != _spriteFrameOneRow) MyPlayer.CurrentSprite.SetFrame(_spriteFrameOneRow, _spriteFrameOneColumn);
    }
    public override void Update()
    {
        if (_timeToMove > 0) _timeToMove--;
        if (_movingCounter == _lastMovingCounter) MyPlayer.MovingDirection = Direction.None;

        if (_movingCounter == 10)
        {
            _movingCounter = 0;
            if (MyPlayer.CurrentSprite.Column == _spriteFrameOneColumn)
            {
                MyPlayer.CurrentSprite.SetFrame(_spriteFrameTwoRow, _spriteFrameTwoColumn);
            }
            else
            {
                MyPlayer.CurrentSprite.SetFrame(_spriteFrameOneRow, _spriteFrameOneColumn);
            }
        }
        _lastMovingCounter = _movingCounter;
    }

    public override void UseItem(Type itemType, Game1 game)
    {
        if (itemType == typeof(EmptyItem)) _timeToMove = 10;
        if (MyPlayer.Inventory.CanUseItem(itemType) && PlayerProjectilesManager.Instance.TrySpawnProjectile(itemType))
        {
            _timeToMove = 10;
            if (itemType == typeof(IBomb)) MyPlayer.Inventory.Bombs--;
            if (itemType == typeof(IBoomerang)) PlayerProjectilesManager.Instance.SpawnProjectile(new CirclingBoomerang(MyPlayer));
            switch (_lastDirection)
            {
                case Direction.Left:
                    if (itemType == typeof(IBoomerang)) PlayerProjectilesManager.Instance.SpawnProjectile(new BoomerangLeft(MyPlayer));
                    else if (itemType == typeof(IBomb)) PlayerProjectilesManager.Instance.SpawnProjectile(new BombLeft(MyPlayer));
                    break;
                case Direction.Right:
                    if (itemType == typeof(IBoomerang)) PlayerProjectilesManager.Instance.SpawnProjectile(new BoomerangRight(MyPlayer));
                    else if (itemType == typeof(IBomb)) PlayerProjectilesManager.Instance.SpawnProjectile(new BombRight(MyPlayer));
                    break;
                case Direction.Up:
                    if (itemType == typeof(IBoomerang)) PlayerProjectilesManager.Instance.SpawnProjectile(new BoomerangUp(MyPlayer));
                    else if (itemType == typeof(IBomb)) PlayerProjectilesManager.Instance.SpawnProjectile(new BombUp(MyPlayer));
                    break;
                case Direction.Down:
                    if (itemType == typeof(IBoomerang)) PlayerProjectilesManager.Instance.SpawnProjectile(new BoomerangDown(MyPlayer));
                    else if (itemType == typeof(IBomb)) PlayerProjectilesManager.Instance.SpawnProjectile(new BombDown(MyPlayer));
                    break;
            }
        }
    }
    public override void UseSword(Game1 game) { }
    public override void PickupItem(IItem item)
    {
        _timeToMove = 10;
        item.HoldItem(new Vector2(MyPlayer.Hitbox.Left + Width / 2, MyPlayer.Hitbox.Top + Height / 2));
        if (item is RupeeItem) SoundFactory.Instance.PlayGetRupee();
        else if (item is TriforcePieceItem or HeartContainerItem or BowItem or BoomerangItem)
            SoundFactory.Instance.PlayGetKeyItem();
        else if (item is HeartItem or KeyItem) SoundFactory.Instance.PlayGetHeart();
        else SoundFactory.Instance.PlayGetMinorItem();
    }
}