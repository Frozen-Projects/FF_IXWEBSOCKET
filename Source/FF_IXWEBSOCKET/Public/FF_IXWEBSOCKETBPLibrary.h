// Copyright Epic Games, Inc. All Rights Reserved.

#pragma once

#include "Kismet/BlueprintFunctionLibrary.h"

#include "FF_IXWS_Includes.h"

#include "FF_IXWEBSOCKETBPLibrary.generated.h"

UCLASS()
class UFF_IXWEBSOCKETBPLibrary : public UBlueprintFunctionLibrary
{
	GENERATED_UCLASS_BODY()

	UFUNCTION(BlueprintCallable, meta = (DisplayName = "Execute Sample function", Keywords = "FF_IXWEBSOCKET sample test testing"), Category = "FF_IXWEBSOCKETTesting")
	static float FF_IXWEBSOCKETSampleFunction(float Param);
};
