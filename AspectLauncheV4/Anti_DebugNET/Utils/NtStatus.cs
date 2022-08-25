using System;

namespace Anti_DebugNET.Utils
{
	// Token: 0x02000004 RID: 4
	public enum NtStatus : uint
	{
		// Token: 0x04000007 RID: 7
		Success,
		// Token: 0x04000008 RID: 8
		Wait0 = 0U,
		// Token: 0x04000009 RID: 9
		Wait1,
		// Token: 0x0400000A RID: 10
		Wait2,
		// Token: 0x0400000B RID: 11
		Wait3,
		// Token: 0x0400000C RID: 12
		Wait63 = 63U,
		// Token: 0x0400000D RID: 13
		Abandoned = 128U,
		// Token: 0x0400000E RID: 14
		AbandonedWait0 = 128U,
		// Token: 0x0400000F RID: 15
		AbandonedWait1,
		// Token: 0x04000010 RID: 16
		AbandonedWait2,
		// Token: 0x04000011 RID: 17
		AbandonedWait3,
		// Token: 0x04000012 RID: 18
		AbandonedWait63 = 191U,
		// Token: 0x04000013 RID: 19
		UserApc,
		// Token: 0x04000014 RID: 20
		KernelApc = 256U,
		// Token: 0x04000015 RID: 21
		Alerted,
		// Token: 0x04000016 RID: 22
		Timeout,
		// Token: 0x04000017 RID: 23
		Pending,
		// Token: 0x04000018 RID: 24
		Reparse,
		// Token: 0x04000019 RID: 25
		MoreEntries,
		// Token: 0x0400001A RID: 26
		NotAllAssigned,
		// Token: 0x0400001B RID: 27
		SomeNotMapped,
		// Token: 0x0400001C RID: 28
		OpLockBreakInProgress,
		// Token: 0x0400001D RID: 29
		VolumeMounted,
		// Token: 0x0400001E RID: 30
		RxActCommitted,
		// Token: 0x0400001F RID: 31
		NotifyCleanup,
		// Token: 0x04000020 RID: 32
		NotifyEnumDir,
		// Token: 0x04000021 RID: 33
		NoQuotasForAccount,
		// Token: 0x04000022 RID: 34
		PrimaryTransportConnectFailed,
		// Token: 0x04000023 RID: 35
		PageFaultTransition = 272U,
		// Token: 0x04000024 RID: 36
		PageFaultDemandZero,
		// Token: 0x04000025 RID: 37
		PageFaultCopyOnWrite,
		// Token: 0x04000026 RID: 38
		PageFaultGuardPage,
		// Token: 0x04000027 RID: 39
		PageFaultPagingFile,
		// Token: 0x04000028 RID: 40
		CrashDump = 278U,
		// Token: 0x04000029 RID: 41
		ReparseObject = 280U,
		// Token: 0x0400002A RID: 42
		NothingToTerminate = 290U,
		// Token: 0x0400002B RID: 43
		ProcessNotInJob,
		// Token: 0x0400002C RID: 44
		ProcessInJob,
		// Token: 0x0400002D RID: 45
		ProcessCloned = 297U,
		// Token: 0x0400002E RID: 46
		FileLockedWithOnlyReaders,
		// Token: 0x0400002F RID: 47
		FileLockedWithWriters,
		// Token: 0x04000030 RID: 48
		Informational = 1073741824U,
		// Token: 0x04000031 RID: 49
		ObjectNameExists = 1073741824U,
		// Token: 0x04000032 RID: 50
		ThreadWasSuspended,
		// Token: 0x04000033 RID: 51
		WorkingSetLimitRange,
		// Token: 0x04000034 RID: 52
		ImageNotAtBase,
		// Token: 0x04000035 RID: 53
		RegistryRecovered = 1073741833U,
		// Token: 0x04000036 RID: 54
		Warning = 2147483648U,
		// Token: 0x04000037 RID: 55
		GuardPageViolation,
		// Token: 0x04000038 RID: 56
		DatatypeMisalignment,
		// Token: 0x04000039 RID: 57
		Breakpoint,
		// Token: 0x0400003A RID: 58
		SingleStep,
		// Token: 0x0400003B RID: 59
		BufferOverflow,
		// Token: 0x0400003C RID: 60
		NoMoreFiles,
		// Token: 0x0400003D RID: 61
		HandlesClosed = 2147483658U,
		// Token: 0x0400003E RID: 62
		PartialCopy = 2147483661U,
		// Token: 0x0400003F RID: 63
		DeviceBusy = 2147483665U,
		// Token: 0x04000040 RID: 64
		InvalidEaName = 2147483667U,
		// Token: 0x04000041 RID: 65
		EaListInconsistent,
		// Token: 0x04000042 RID: 66
		NoMoreEntries = 2147483674U,
		// Token: 0x04000043 RID: 67
		LongJump = 2147483686U,
		// Token: 0x04000044 RID: 68
		DllMightBeInsecure = 2147483691U,
		// Token: 0x04000045 RID: 69
		Error = 3221225472U,
		// Token: 0x04000046 RID: 70
		Unsuccessful,
		// Token: 0x04000047 RID: 71
		NotImplemented,
		// Token: 0x04000048 RID: 72
		InvalidInfoClass,
		// Token: 0x04000049 RID: 73
		InfoLengthMismatch,
		// Token: 0x0400004A RID: 74
		AccessViolation,
		// Token: 0x0400004B RID: 75
		InPageError,
		// Token: 0x0400004C RID: 76
		PagefileQuota,
		// Token: 0x0400004D RID: 77
		InvalidHandle,
		// Token: 0x0400004E RID: 78
		BadInitialStack,
		// Token: 0x0400004F RID: 79
		BadInitialPc,
		// Token: 0x04000050 RID: 80
		InvalidCid,
		// Token: 0x04000051 RID: 81
		TimerNotCanceled,
		// Token: 0x04000052 RID: 82
		InvalidParameter,
		// Token: 0x04000053 RID: 83
		NoSuchDevice,
		// Token: 0x04000054 RID: 84
		NoSuchFile,
		// Token: 0x04000055 RID: 85
		InvalidDeviceRequest,
		// Token: 0x04000056 RID: 86
		EndOfFile,
		// Token: 0x04000057 RID: 87
		WrongVolume,
		// Token: 0x04000058 RID: 88
		NoMediaInDevice,
		// Token: 0x04000059 RID: 89
		NoMemory = 3221225495U,
		// Token: 0x0400005A RID: 90
		NotMappedView = 3221225497U,
		// Token: 0x0400005B RID: 91
		UnableToFreeVm,
		// Token: 0x0400005C RID: 92
		UnableToDeleteSection,
		// Token: 0x0400005D RID: 93
		IllegalInstruction = 3221225501U,
		// Token: 0x0400005E RID: 94
		AlreadyCommitted = 3221225505U,
		// Token: 0x0400005F RID: 95
		AccessDenied,
		// Token: 0x04000060 RID: 96
		BufferTooSmall,
		// Token: 0x04000061 RID: 97
		ObjectTypeMismatch,
		// Token: 0x04000062 RID: 98
		NonContinuableException,
		// Token: 0x04000063 RID: 99
		BadStack = 3221225512U,
		// Token: 0x04000064 RID: 100
		NotLocked = 3221225514U,
		// Token: 0x04000065 RID: 101
		NotCommitted = 3221225517U,
		// Token: 0x04000066 RID: 102
		InvalidParameterMix = 3221225520U,
		// Token: 0x04000067 RID: 103
		ObjectNameInvalid = 3221225523U,
		// Token: 0x04000068 RID: 104
		ObjectNameNotFound,
		// Token: 0x04000069 RID: 105
		ObjectNameCollision,
		// Token: 0x0400006A RID: 106
		ObjectPathInvalid = 3221225529U,
		// Token: 0x0400006B RID: 107
		ObjectPathNotFound,
		// Token: 0x0400006C RID: 108
		ObjectPathSyntaxBad,
		// Token: 0x0400006D RID: 109
		DataOverrun,
		// Token: 0x0400006E RID: 110
		DataLate,
		// Token: 0x0400006F RID: 111
		DataError,
		// Token: 0x04000070 RID: 112
		CrcError,
		// Token: 0x04000071 RID: 113
		SectionTooBig,
		// Token: 0x04000072 RID: 114
		PortConnectionRefused,
		// Token: 0x04000073 RID: 115
		InvalidPortHandle,
		// Token: 0x04000074 RID: 116
		SharingViolation,
		// Token: 0x04000075 RID: 117
		QuotaExceeded,
		// Token: 0x04000076 RID: 118
		InvalidPageProtection,
		// Token: 0x04000077 RID: 119
		MutantNotOwned,
		// Token: 0x04000078 RID: 120
		SemaphoreLimitExceeded,
		// Token: 0x04000079 RID: 121
		PortAlreadySet,
		// Token: 0x0400007A RID: 122
		SectionNotImage,
		// Token: 0x0400007B RID: 123
		SuspendCountExceeded,
		// Token: 0x0400007C RID: 124
		ThreadIsTerminating,
		// Token: 0x0400007D RID: 125
		BadWorkingSetLimit,
		// Token: 0x0400007E RID: 126
		IncompatibleFileMap,
		// Token: 0x0400007F RID: 127
		SectionProtection,
		// Token: 0x04000080 RID: 128
		EasNotSupported,
		// Token: 0x04000081 RID: 129
		EaTooLarge,
		// Token: 0x04000082 RID: 130
		NonExistentEaEntry,
		// Token: 0x04000083 RID: 131
		NoEasOnFile,
		// Token: 0x04000084 RID: 132
		EaCorruptError,
		// Token: 0x04000085 RID: 133
		FileLockConflict,
		// Token: 0x04000086 RID: 134
		LockNotGranted,
		// Token: 0x04000087 RID: 135
		DeletePending,
		// Token: 0x04000088 RID: 136
		CtlFileNotSupported,
		// Token: 0x04000089 RID: 137
		UnknownRevision,
		// Token: 0x0400008A RID: 138
		RevisionMismatch,
		// Token: 0x0400008B RID: 139
		InvalidOwner,
		// Token: 0x0400008C RID: 140
		InvalidPrimaryGroup,
		// Token: 0x0400008D RID: 141
		NoImpersonationToken,
		// Token: 0x0400008E RID: 142
		CantDisableMandatory,
		// Token: 0x0400008F RID: 143
		NoLogonServers,
		// Token: 0x04000090 RID: 144
		NoSuchLogonSession,
		// Token: 0x04000091 RID: 145
		NoSuchPrivilege,
		// Token: 0x04000092 RID: 146
		PrivilegeNotHeld,
		// Token: 0x04000093 RID: 147
		InvalidAccountName,
		// Token: 0x04000094 RID: 148
		UserExists,
		// Token: 0x04000095 RID: 149
		NoSuchUser,
		// Token: 0x04000096 RID: 150
		GroupExists,
		// Token: 0x04000097 RID: 151
		NoSuchGroup,
		// Token: 0x04000098 RID: 152
		MemberInGroup,
		// Token: 0x04000099 RID: 153
		MemberNotInGroup,
		// Token: 0x0400009A RID: 154
		LastAdmin,
		// Token: 0x0400009B RID: 155
		WrongPassword,
		// Token: 0x0400009C RID: 156
		IllFormedPassword,
		// Token: 0x0400009D RID: 157
		PasswordRestriction,
		// Token: 0x0400009E RID: 158
		LogonFailure,
		// Token: 0x0400009F RID: 159
		AccountRestriction,
		// Token: 0x040000A0 RID: 160
		InvalidLogonHours,
		// Token: 0x040000A1 RID: 161
		InvalidWorkstation,
		// Token: 0x040000A2 RID: 162
		PasswordExpired,
		// Token: 0x040000A3 RID: 163
		AccountDisabled,
		// Token: 0x040000A4 RID: 164
		NoneMapped,
		// Token: 0x040000A5 RID: 165
		TooManyLuidsRequested,
		// Token: 0x040000A6 RID: 166
		LuidsExhausted,
		// Token: 0x040000A7 RID: 167
		InvalidSubAuthority,
		// Token: 0x040000A8 RID: 168
		InvalidAcl,
		// Token: 0x040000A9 RID: 169
		InvalidSid,
		// Token: 0x040000AA RID: 170
		InvalidSecurityDescr,
		// Token: 0x040000AB RID: 171
		ProcedureNotFound,
		// Token: 0x040000AC RID: 172
		InvalidImageFormat,
		// Token: 0x040000AD RID: 173
		NoToken,
		// Token: 0x040000AE RID: 174
		BadInheritanceAcl,
		// Token: 0x040000AF RID: 175
		RangeNotLocked,
		// Token: 0x040000B0 RID: 176
		DiskFull,
		// Token: 0x040000B1 RID: 177
		ServerDisabled,
		// Token: 0x040000B2 RID: 178
		ServerNotDisabled,
		// Token: 0x040000B3 RID: 179
		TooManyGuidsRequested,
		// Token: 0x040000B4 RID: 180
		GuidsExhausted,
		// Token: 0x040000B5 RID: 181
		InvalidIdAuthority,
		// Token: 0x040000B6 RID: 182
		AgentsExhausted,
		// Token: 0x040000B7 RID: 183
		InvalidVolumeLabel,
		// Token: 0x040000B8 RID: 184
		SectionNotExtended,
		// Token: 0x040000B9 RID: 185
		NotMappedData,
		// Token: 0x040000BA RID: 186
		ResourceDataNotFound,
		// Token: 0x040000BB RID: 187
		ResourceTypeNotFound,
		// Token: 0x040000BC RID: 188
		ResourceNameNotFound,
		// Token: 0x040000BD RID: 189
		ArrayBoundsExceeded,
		// Token: 0x040000BE RID: 190
		FloatDenormalOperand,
		// Token: 0x040000BF RID: 191
		FloatDivideByZero,
		// Token: 0x040000C0 RID: 192
		FloatInexactResult,
		// Token: 0x040000C1 RID: 193
		FloatInvalidOperation,
		// Token: 0x040000C2 RID: 194
		FloatOverflow,
		// Token: 0x040000C3 RID: 195
		FloatStackCheck,
		// Token: 0x040000C4 RID: 196
		FloatUnderflow,
		// Token: 0x040000C5 RID: 197
		IntegerDivideByZero,
		// Token: 0x040000C6 RID: 198
		IntegerOverflow,
		// Token: 0x040000C7 RID: 199
		PrivilegedInstruction,
		// Token: 0x040000C8 RID: 200
		TooManyPagingFiles,
		// Token: 0x040000C9 RID: 201
		FileInvalid,
		// Token: 0x040000CA RID: 202
		InstanceNotAvailable = 3221225643U,
		// Token: 0x040000CB RID: 203
		PipeNotAvailable,
		// Token: 0x040000CC RID: 204
		InvalidPipeState,
		// Token: 0x040000CD RID: 205
		PipeBusy,
		// Token: 0x040000CE RID: 206
		IllegalFunction,
		// Token: 0x040000CF RID: 207
		PipeDisconnected,
		// Token: 0x040000D0 RID: 208
		PipeClosing,
		// Token: 0x040000D1 RID: 209
		PipeConnected,
		// Token: 0x040000D2 RID: 210
		PipeListening,
		// Token: 0x040000D3 RID: 211
		InvalidReadMode,
		// Token: 0x040000D4 RID: 212
		IoTimeout,
		// Token: 0x040000D5 RID: 213
		FileForcedClosed,
		// Token: 0x040000D6 RID: 214
		ProfilingNotStarted,
		// Token: 0x040000D7 RID: 215
		ProfilingNotStopped,
		// Token: 0x040000D8 RID: 216
		NotSameDevice = 3221225684U,
		// Token: 0x040000D9 RID: 217
		FileRenamed,
		// Token: 0x040000DA RID: 218
		CantWait = 3221225688U,
		// Token: 0x040000DB RID: 219
		PipeEmpty,
		// Token: 0x040000DC RID: 220
		CantTerminateSelf = 3221225691U,
		// Token: 0x040000DD RID: 221
		InternalError = 3221225701U,
		// Token: 0x040000DE RID: 222
		InvalidParameter1 = 3221225711U,
		// Token: 0x040000DF RID: 223
		InvalidParameter2,
		// Token: 0x040000E0 RID: 224
		InvalidParameter3,
		// Token: 0x040000E1 RID: 225
		InvalidParameter4,
		// Token: 0x040000E2 RID: 226
		InvalidParameter5,
		// Token: 0x040000E3 RID: 227
		InvalidParameter6,
		// Token: 0x040000E4 RID: 228
		InvalidParameter7,
		// Token: 0x040000E5 RID: 229
		InvalidParameter8,
		// Token: 0x040000E6 RID: 230
		InvalidParameter9,
		// Token: 0x040000E7 RID: 231
		InvalidParameter10,
		// Token: 0x040000E8 RID: 232
		InvalidParameter11,
		// Token: 0x040000E9 RID: 233
		InvalidParameter12,
		// Token: 0x040000EA RID: 234
		MappedFileSizeZero = 3221225758U,
		// Token: 0x040000EB RID: 235
		TooManyOpenedFiles,
		// Token: 0x040000EC RID: 236
		Cancelled,
		// Token: 0x040000ED RID: 237
		CannotDelete,
		// Token: 0x040000EE RID: 238
		InvalidComputerName,
		// Token: 0x040000EF RID: 239
		FileDeleted,
		// Token: 0x040000F0 RID: 240
		SpecialAccount,
		// Token: 0x040000F1 RID: 241
		SpecialGroup,
		// Token: 0x040000F2 RID: 242
		SpecialUser,
		// Token: 0x040000F3 RID: 243
		MembersPrimaryGroup,
		// Token: 0x040000F4 RID: 244
		FileClosed,
		// Token: 0x040000F5 RID: 245
		TooManyThreads,
		// Token: 0x040000F6 RID: 246
		ThreadNotInProcess,
		// Token: 0x040000F7 RID: 247
		TokenAlreadyInUse,
		// Token: 0x040000F8 RID: 248
		PagefileQuotaExceeded,
		// Token: 0x040000F9 RID: 249
		CommitmentLimit,
		// Token: 0x040000FA RID: 250
		InvalidImageLeFormat,
		// Token: 0x040000FB RID: 251
		InvalidImageNotMz,
		// Token: 0x040000FC RID: 252
		InvalidImageProtect,
		// Token: 0x040000FD RID: 253
		InvalidImageWin16,
		// Token: 0x040000FE RID: 254
		LogonServer,
		// Token: 0x040000FF RID: 255
		DifferenceAtDc,
		// Token: 0x04000100 RID: 256
		SynchronizationRequired,
		// Token: 0x04000101 RID: 257
		DllNotFound,
		// Token: 0x04000102 RID: 258
		IoPrivilegeFailed = 3221225783U,
		// Token: 0x04000103 RID: 259
		OrdinalNotFound,
		// Token: 0x04000104 RID: 260
		EntryPointNotFound,
		// Token: 0x04000105 RID: 261
		ControlCExit,
		// Token: 0x04000106 RID: 262
		PortNotSet = 3221226323U,
		// Token: 0x04000107 RID: 263
		DebuggerInactive,
		// Token: 0x04000108 RID: 264
		CallbackBypass = 3221226755U,
		// Token: 0x04000109 RID: 265
		PortClosed = 3221227264U,
		// Token: 0x0400010A RID: 266
		MessageLost,
		// Token: 0x0400010B RID: 267
		InvalidMessage,
		// Token: 0x0400010C RID: 268
		RequestCanceled,
		// Token: 0x0400010D RID: 269
		RecursiveDispatch,
		// Token: 0x0400010E RID: 270
		LpcReceiveBufferExpected,
		// Token: 0x0400010F RID: 271
		LpcInvalidConnectionUsage,
		// Token: 0x04000110 RID: 272
		LpcRequestsNotAllowed,
		// Token: 0x04000111 RID: 273
		ResourceInUse,
		// Token: 0x04000112 RID: 274
		ProcessIsProtected = 3221227282U,
		// Token: 0x04000113 RID: 275
		VolumeDirty = 3221227526U,
		// Token: 0x04000114 RID: 276
		FileCheckedOut = 3221227777U,
		// Token: 0x04000115 RID: 277
		CheckOutRequired,
		// Token: 0x04000116 RID: 278
		BadFileType,
		// Token: 0x04000117 RID: 279
		FileTooLarge,
		// Token: 0x04000118 RID: 280
		FormsAuthRequired,
		// Token: 0x04000119 RID: 281
		VirusInfected,
		// Token: 0x0400011A RID: 282
		VirusDeleted,
		// Token: 0x0400011B RID: 283
		TransactionalConflict = 3222863873U,
		// Token: 0x0400011C RID: 284
		InvalidTransaction,
		// Token: 0x0400011D RID: 285
		TransactionNotActive,
		// Token: 0x0400011E RID: 286
		TmInitializationFailed,
		// Token: 0x0400011F RID: 287
		RmNotActive,
		// Token: 0x04000120 RID: 288
		RmMetadataCorrupt,
		// Token: 0x04000121 RID: 289
		TransactionNotJoined,
		// Token: 0x04000122 RID: 290
		DirectoryNotRm,
		// Token: 0x04000123 RID: 291
		CouldNotResizeLog,
		// Token: 0x04000124 RID: 292
		TransactionsUnsupportedRemote,
		// Token: 0x04000125 RID: 293
		LogResizeInvalidSize,
		// Token: 0x04000126 RID: 294
		RemoteFileVersionMismatch,
		// Token: 0x04000127 RID: 295
		CrmProtocolAlreadyExists = 3222863887U,
		// Token: 0x04000128 RID: 296
		TransactionPropagationFailed,
		// Token: 0x04000129 RID: 297
		CrmProtocolNotFound,
		// Token: 0x0400012A RID: 298
		TransactionSuperiorExists,
		// Token: 0x0400012B RID: 299
		TransactionRequestNotValid,
		// Token: 0x0400012C RID: 300
		TransactionNotRequested,
		// Token: 0x0400012D RID: 301
		TransactionAlreadyAborted,
		// Token: 0x0400012E RID: 302
		TransactionAlreadyCommitted,
		// Token: 0x0400012F RID: 303
		TransactionInvalidMarshallBuffer,
		// Token: 0x04000130 RID: 304
		CurrentTransactionNotValid,
		// Token: 0x04000131 RID: 305
		LogGrowthFailed,
		// Token: 0x04000132 RID: 306
		ObjectNoLongerExists = 3222863905U,
		// Token: 0x04000133 RID: 307
		StreamMiniversionNotFound,
		// Token: 0x04000134 RID: 308
		StreamMiniversionNotValid,
		// Token: 0x04000135 RID: 309
		MiniversionInaccessibleFromSpecifiedTransaction,
		// Token: 0x04000136 RID: 310
		CantOpenMiniversionWithModifyIntent,
		// Token: 0x04000137 RID: 311
		CantCreateMoreStreamMiniversions,
		// Token: 0x04000138 RID: 312
		HandleNoLongerValid = 3222863912U,
		// Token: 0x04000139 RID: 313
		NoTxfMetadata,
		// Token: 0x0400013A RID: 314
		LogCorruptionDetected = 3222863920U,
		// Token: 0x0400013B RID: 315
		CantRecoverWithHandleOpen,
		// Token: 0x0400013C RID: 316
		RmDisconnected,
		// Token: 0x0400013D RID: 317
		EnlistmentNotSuperior,
		// Token: 0x0400013E RID: 318
		RecoveryNotNeeded,
		// Token: 0x0400013F RID: 319
		RmAlreadyStarted,
		// Token: 0x04000140 RID: 320
		FileIdentityNotPersistent,
		// Token: 0x04000141 RID: 321
		CantBreakTransactionalDependency,
		// Token: 0x04000142 RID: 322
		CantCrossRmBoundary,
		// Token: 0x04000143 RID: 323
		TxfDirNotEmpty,
		// Token: 0x04000144 RID: 324
		IndoubtTransactionsExist,
		// Token: 0x04000145 RID: 325
		TmVolatile,
		// Token: 0x04000146 RID: 326
		RollbackTimerExpired,
		// Token: 0x04000147 RID: 327
		TxfAttributeCorrupt,
		// Token: 0x04000148 RID: 328
		EfsNotAllowedInTransaction,
		// Token: 0x04000149 RID: 329
		TransactionalOpenNotAllowed,
		// Token: 0x0400014A RID: 330
		TransactedMappingUnsupportedRemote,
		// Token: 0x0400014B RID: 331
		TxfMetadataAlreadyPresent,
		// Token: 0x0400014C RID: 332
		TransactionScopeCallbacksNotSet,
		// Token: 0x0400014D RID: 333
		TransactionRequiredPromotion,
		// Token: 0x0400014E RID: 334
		CannotExecuteFileInTransaction,
		// Token: 0x0400014F RID: 335
		TransactionsNotFrozen,
		// Token: 0x04000150 RID: 336
		MaximumNtStatus = 4294967295U
	}
}
