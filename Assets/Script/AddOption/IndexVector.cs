﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public struct IndexVector
{
    public int x;
    public int y;

    public override string ToString()
    {
        return "x:" + x + "   y:" + y;
    }

    public static IndexVector right {
        get => new IndexVector(1, 0);
    }
    public static IndexVector left {
        get => new IndexVector(-1, 0);
    }
    public static IndexVector up {
        get => new IndexVector(0, -1);
    }
    public static IndexVector down {
        get => new IndexVector(0, 1);
    }
    public static IndexVector zero {
        get => new IndexVector(0, 0);
    }

    //입력받은 MoveDirection 에 일치하는 방향 벡터를 반환합니다
    public static IndexVector GetMoveDirectionToIndexVector(MoveDirection direction)
    {
        switch (direction)
        {
            case MoveDirection.None:
                return zero;
            case MoveDirection.Left:
                return left;
            case MoveDirection.Right:
                return right;
            case MoveDirection.Up:
                return up;
            case MoveDirection.Down:
                return down;
            default:
                return zero;
        }
    }


    public IndexVector(int x, int y)
    {
        this.x = x;
        this.y = y;
    }

    public IndexVector(IndexVector iv)
    {
        this.x = iv.x;
        this.y = iv.y;
    }

    

    public void Set(int x, int y)
    {
        this.x = x;
        this.y = y;
    }
    public void Set(IndexVector iv)
    {
        this.x = iv.x;
        this.y = iv.y;
    }
    

    //일반 실수 2개를 인덱스 벡터로 전환합니다
    public void CastIndexVector(float x, float y)
    {
        this.x = (int)x;
        this.y = (int)y;
    }
    
    //일반 벡터를 인덱스 벡터로 전환합니다
    public void CastIndexVector(Vector2 v)
    {
        this.x = (int)v.x;
        this.y = (int)v.y;
    }

    public static IndexVector operator + (IndexVector iv1, IndexVector iv2)
    {
        return new IndexVector(iv1.x + iv2.x, iv1.y + iv2.y);
    }

    public static IndexVector operator - (IndexVector iv1, IndexVector iv2)
    {
        return new IndexVector(iv1.x - iv2.x, iv1.y - iv2.y);
    }
}