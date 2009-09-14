		// Magical file name used for file adds or deletes.
		/// length of <code><see cref="ParentCount"/> + 1</code>
		/// <li><i>file modify</i>: always <see cref="NewName"/></li>
		/// <li><i>file modify</i>: always <see cref="OldName"/></li>
		/// <li><i>file rename</i>: destination file the rename ends up at</li>
		/// Returns similarity score between <see cref="OldName"/> and
		/// <see cref="NewName"/> if <see cref="getChangeType()"/> is
		/// <see cref="ChangeTypeEnum.COPY"/> or <see cref="ChangeTypeEnum.RENAME"/>.
		/// If a <see cref="PatchTypeEnum.GIT_BINARY"/>, the new-image delta/literal
		/// If a <see cref="PatchTypeEnum.GIT_BINARY"/>, the old-image delta/literal